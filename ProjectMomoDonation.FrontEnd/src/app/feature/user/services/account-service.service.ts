import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DonationProgramModel } from '../model/donation-program.model';
import { BehaviorSubject, Observable } from 'rxjs';
import { OrganizationFundraiseModel } from '../model/organization-fundraise.model';
import { CategoryModel } from '../model/category.model';
import { Environment } from '../environment';
import { LoginRequestModel } from '../model/login-request.model';
import { LoginResponseModel } from '../model/login-response.model';
import { UserModel } from '../model/user.model';
import { CookieService } from 'ngx-cookie-service';
import { RegisterRequestModel } from '../model/register-request.model';
import { ChangePasswordRequestModel } from '../model/change-password-request-model';
@Injectable({
  providedIn: 'root'
})
export class AccountService {

  $user = new BehaviorSubject<UserModel | undefined>(undefined);
  constructor(private http: HttpClient, private cookieService : CookieService) { }
  login(request: LoginRequestModel) : Observable<LoginResponseModel>{
  return this.http.post<LoginResponseModel>(`${Environment.apiBaseUrl}/api/Auth/Login`,{
    username: request.username,
    password: request.password
  })
  }
  register(request: RegisterRequestModel) : Observable<void>{
  return this.http.post<void>(`${Environment.apiBaseUrl}/api/Auth/Register`,{
    username: request.username,
    password: request.password,
    roles: request.roles,
    status: request.status,
  })
  }
  setUser(user: UserModel){
    this.$user.next(user);
    localStorage.setItem('user-name',user.username);
    localStorage.setItem('user-roles',user.roles.join(','));
    localStorage.setItem('user-status',user.status);
  }
  getUser() : UserModel | undefined{

    const name = localStorage.getItem('user-name');
    const role = localStorage.getItem('user-roles');
    const status = localStorage.getItem('user-status');

    if(name && role){
      const user : UserModel = {
        username : name,
        roles : role.split(','),
        status : status
      };
      return user
    }
    return undefined
  }
  user() :Observable<UserModel | undefined>{
    return this.$user.asObservable();
  }
  logout(){
    localStorage.clear();
    this.cookieService.delete('Authorization','/');
    this.$user.next(undefined);
  }
  changePassword(model : ChangePasswordRequestModel) : Observable<string>
  {
    return this.http.put<string>(
      `${Environment.apiBaseUrl}/api/Auth/ChangePassword`,{
        userName: model.userName,
        oldPassword: model.oldPassword,
        newPassword: model.newPassword
      }
    )
  }
  forgotPassword(username: string) : Observable<void>{
    return this.http.post<void>(
      `${Environment.apiBaseUrl}/api/Auth/ForgotPassword?email=${username}`,''
    )
  }
}
