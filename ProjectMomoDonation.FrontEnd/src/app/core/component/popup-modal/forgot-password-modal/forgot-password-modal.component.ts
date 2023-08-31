import { publishFacade } from '@angular/compiler';
import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { AccountService } from 'src/app/feature/user/services/account-service.service';

@Component({
  selector: 'app-forgot-password-modal',
  templateUrl: './forgot-password-modal.component.html',
  styleUrls: ['./forgot-password-modal.component.css'],
})
export class ForgotPasswordModalComponent {
  username = '';
  constructor(
    @Inject(MAT_DIALOG_DATA) public data: string,
    private service: AccountService,
    public dialogRef: MatDialogRef<ForgotPasswordModalComponent>,
    private snackBar: MatSnackBar
  ) {}
  forgotPasswordRequest() {
    this.service.forgotPassword(this.username).subscribe({
      next: () => {
        this.snackBar.open(
          `Mật khẩu của bạn đã được tạo mới và gửi qua địa chỉ mail ${this.username}`,
          '',
          {
            duration: 5000,
            horizontalPosition: 'center',
            verticalPosition: 'top',
          }
        );
      },
      error: () =>{
        this.snackBar.open(
          `Địa chỉ mail không tồn tại`,
          '',
          {
            duration: 5000,
            horizontalPosition: 'center',
            verticalPosition: 'top',
          }
        );
      }
    });
  }
}
