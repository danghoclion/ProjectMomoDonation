import { Injectable } from '@angular/core';
import { Environment } from '../user/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { OrganizationFundraiseModel } from '../user/model/organization-fundraise.model';
import { OrganizationCreateModel } from '../user/model/organization-create.model';
import { DonationProgramModel } from '../user/model/donation-program.model';
import { ProgramCreateModel } from '../user/model/program-create.model';
import { UserManageModel } from '../user/model/user-manage.model';
@Injectable({
  providedIn: 'root'
})
export class AdminService {

  constructor(private http: HttpClient) { }

  //Organization Service
  getAllOrganization() : Observable<OrganizationFundraiseModel[]>{
  return this.http.get<OrganizationFundraiseModel[]>(
    `${Environment.apiBaseUrl}/api/OrganizationFundraise`
  )
  }
  getOrganizationById(id : string) : Observable<OrganizationFundraiseModel>{
    return this.http.get<OrganizationFundraiseModel>(
      `${Environment.apiBaseUrl}/api/OrganizationFundraise/${id}`
    )
  }
  createNewOrganization(model : OrganizationCreateModel) : Observable<void>{
    return this.http.post<void>(
      `${Environment.apiBaseUrl}/api/OrganizationFundraise`,{
        name: model.name,
        shortName: model.shortName,
        description: model.description,
        avatar: model.avatar,
        image: model.image,
        urlSlug: model.urlSlug
      }
    )
  }
  updateNewOrganization(id:string, model : OrganizationCreateModel) : Observable<void>{
    return this.http.put<void>(
      `${Environment.apiBaseUrl}/api/OrganizationFundraise/${id}`,{
        name: model.name,
        shortName: model.shortName,
        description: model.description,
        avatar: model.avatar,
        image: model.image,
        urlSlug: model.urlSlug
      }
    )
  }
  deleteOrganization(id: string) : Observable<void>{
    return this.http.delete<void>(
      `${Environment.apiBaseUrl}/api/OrganizationFundraise/${id}`
    )
  }

  //Donation Program Service
  getAllProgram() : Observable<DonationProgramModel[]>{
    return this.http.get<DonationProgramModel[]>(
      `${Environment.apiBaseUrl}/api/ProgramDonation/filter`
    )
    }
  getProgramById(id : string) : Observable<DonationProgramModel>{
      return this.http.get<DonationProgramModel>(
        `${Environment.apiBaseUrl}/api/ProgramDonation/${id}`
      )
    }
  createNewProgram(model : ProgramCreateModel) : Observable<void>{
      return this.http.post<void>(
        `${Environment.apiBaseUrl}/api/ProgramDonation`,{
          title: model.title,
          avatarUrl: model.avatarUrl,
          urlSlug: model.urlSlug,
          shortTitle: model.shortTitle,
          story: model.story,
          dateStart: model.dateStart,
          dateEnd: model.dateEnd,
          totalDonate: model.totalDonate,
          donationGoal: model.donationGoal,
          categoryName: model.categoryName,
          organizationName: model.organizationName,
        }
      )
    }
  updateProgram(id:string, model : DonationProgramModel) : Observable<void>{
      return this.http.put<void>(
        `${Environment.apiBaseUrl}/api/ProgramDonation/${id}`,{
          title: model.title,
          avatarUrl: model.avatarUrl,
          urlSlug: model.urlSlug,
          shortTitle: model.shortTitle,
          story: model.story,
          dateStart: model.dateStart,
          dateEnd: model.dateEnd,
          totalDonate: model.totalDonate,
          donationGoal: model.donationGoal,
          categoryName: model.categoryName,
          organizationName: model.organizationName,
        }
      )
    }
  updateStatus(id:string, status: string) : Observable<void>{
    return this.http.put<void>(
      `${Environment.apiBaseUrl}/api/ProgramDonation/UpdateStatus/${id}?status=${status}`,{}
    )
  }
  deleteProgram(id: string) : Observable<void>{
      return this.http.delete<void>(
        `${Environment.apiBaseUrl}/api/ProgramDonation/${id}`
      )
    }

  //User Service
  getAllUser() : Observable<UserManageModel[]>{
    return this.http.get<UserManageModel[]>(
      `${Environment.apiBaseUrl}/api/Users`
    )
  }
  setUserStatus(userName: string,status: string) : Observable<void>{
    return this.http.post<void>(
      `${Environment.apiBaseUrl}/api/Users?userName=${userName}&status=${status}`,{}
    )
  }
}
