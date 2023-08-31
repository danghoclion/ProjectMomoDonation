import { Component, Inject } from '@angular/core';
import { LoginRequestModel } from '../model/login-request.model';
import { AccountService } from '../services/account-service.service';
import { CookieService } from 'ngx-cookie-service';
import { Router } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MAT_DIALOG_DATA, MatDialog, MatDialogRef } from '@angular/material/dialog';
import { ForgotPasswordModalComponent } from 'src/app/core/component/popup-modal/forgot-password-modal/forgot-password-modal.component';


@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css'],
})
export class LoginPageComponent {
  model: LoginRequestModel;

  constructor(
    private accountService: AccountService,
    private cookieService: CookieService,
    private router: Router,
    private snackBar: MatSnackBar,
    public dialog: MatDialog,
    
  ) {
    this.model = {
      username: '',
      password: '',
    };
  }
  onLoginRequest(): void {
    this.accountService.login(this.model).subscribe({
      next: (response) => {
        //Set auth cookie
        this.cookieService.set(
          'Authorization',
          `Bearer ${response.jwtToken}`,
          undefined,
          '/',
          undefined,
          true,
          'Strict'
        );
        //Set user to local
        this.accountService.setUser({
          username: response.name,
          roles: response.roleName,
          status: response.status,
        });

        //Redirect back to Home
        if (localStorage.getItem('user-roles') === 'admin') {
          this.router.navigateByUrl('/admin/organization');
          // Login success as admin
          this.snackBar.open(
            `Bạn đăng nhập với tư cách ${localStorage.getItem('user-roles')}`,
            '',
            {
              duration: 2000,
              horizontalPosition: 'center',
              verticalPosition: 'top',
            }
          );
        } else if (localStorage.getItem('user-status') != 'Blocked') {
          this.router.navigateByUrl('/trai-tim-momo');
          // Login success as guest
          this.snackBar.open(
            `Bạn đăng nhập với tư cách ${localStorage.getItem('user-roles')}`,
            '',
            {
              duration: 2000,
              horizontalPosition: 'center',
              verticalPosition: 'top',
            }
          );
        } else if (localStorage.getItem('user-status') === 'Blocked') {
          // Account blocked
          this.snackBar.open(
            `Tài khoản của bạn đã bị khoá. Vui lòng liên hệ admin để được hỗ trợ`,
            'Đóng',
            {
              duration: 10000,
              horizontalPosition: 'center',
              verticalPosition: 'top',
            }
          );
        }
      },
      error : () =>{
        this.snackBar.open(
          `Sai thông tin đăng nhập. Vui lòng kiểm tra lại`,
          'Đóng',
          {
            duration: 5000,
            horizontalPosition: 'center',
            verticalPosition: 'top',
          }
        );
      }
    });
  }
  openDialog() {
    this.dialog.open(ForgotPasswordModalComponent, {
      data: {
        animal: 'panda'
      }
    });
  }
  
}
