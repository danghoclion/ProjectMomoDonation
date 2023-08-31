import { Component } from '@angular/core';
import { RegisterRequestModel } from '../model/register-request.model';
import { AccountService } from '../services/account-service.service';
import { Router } from '@angular/router';
import {
  MatSnackBar,
  MatSnackBarHorizontalPosition,
  MatSnackBarModule,
  MatSnackBarVerticalPosition,
} from '@angular/material/snack-bar';
@Component({
  selector: 'app-register-page',
  templateUrl: './register-page.component.html',
  styleUrls: ['./register-page.component.css']
})
export class RegisterPageComponent {
  model : RegisterRequestModel
  horizontalPosition: MatSnackBarHorizontalPosition = 'center';
  verticalPosition: MatSnackBarVerticalPosition = 'top';
  constructor(private accountService :AccountService, private router: Router,private snackBar : MatSnackBar){
    this.model ={
      username:'',
      password:'',
      repassword:'',
      roles:['guest'],
      status:''
    };
  }
  onRegisterRequest(){
    if (this.model.password !== this.model.repassword) {
      // Passwords don't match
      alert('Mật khẩu khác nhau. Vui lòng nhập lại.');
      return;
    }
    this.accountService.register(this.model).subscribe({
      next :(response: void) => {
        // Success: HTTP 200
        this.snackBar.open('Đăng kí thành công', 'Đóng', {
          duration: 3000, horizontalPosition: this.horizontalPosition,
          verticalPosition: this.verticalPosition, // Show for 3 seconds
        });
        this.router.navigateByUrl('/trai-tim-momo/login')
      },
      error: () => {
        this.snackBar.open('Tài khoản đã tồn tại', 'Đóng', {
          duration: 3000, horizontalPosition: this.horizontalPosition,
          verticalPosition: this.verticalPosition, // Show for 3 seconds
        });
      }
    }
    );
  }
}
