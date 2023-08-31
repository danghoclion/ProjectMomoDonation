import { Component } from '@angular/core';
import { ChangePasswordRequestModel } from '../model/change-password-request-model';
import { AccountService } from '../services/account-service.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-forgot-password-page',
  templateUrl: './forgot-password-page.component.html',
  styleUrls: ['./forgot-password-page.component.css']
})
export class ChangePasswordPageComponent {
  model : ChangePasswordRequestModel
  reNewPassword = "";

  constructor(private service: AccountService, private snackBar : MatSnackBar){
    this.model = {
      userName: "",
      oldPassword: "",
      newPassword: ""
    }
  }

  onChangePasswordRequest(){
    this.service.changePassword(this.model)
    .subscribe({
      next: (response) => {
        this.snackBar.open(
          `Đổi mật khẩu thành công`,
          '',
          {
            duration: 2000,
            horizontalPosition: 'center',
            verticalPosition: 'top',
          }
        );
      },
      // error: () => {
      //   this.snackBar.open(
      //     `Sai thông tin đăng nhập`,
      //     '',
      //     {
      //       duration: 2000,
      //       horizontalPosition: 'center',
      //       verticalPosition: 'top',
      //     }
      //   );
      // }
    })
  }
}
