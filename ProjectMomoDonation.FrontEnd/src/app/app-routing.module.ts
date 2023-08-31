import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserMainPageComponent } from './feature/user/user-main-page/user-main-page.component';
import { UserHcqgPageComponent } from './feature/user/user-hcqg-page/user-hcqg-page.component';
import { UserDtdhPageComponent } from './feature/user/user-dtdh-page/user-dtdh-page.component';
import { UserDetailProgramPageComponent } from './feature/user/user-detail-program-page/user-detail-program-page.component';
import { UserDetailDtdhPageComponent } from './feature/user/user-detail-dtdh-page/user-detail-dtdh-page.component';
import { LoginPageComponent } from './feature/user/login-page/login-page.component';
import { UserDonateHistoryComponent } from './feature/user/user-donate-history/user-donate-history.component';
import { RegisterPageComponent } from './feature/user/register-page/register-page.component';
import { AdminOrganizationIndexComponent } from './feature/admin/admin-organization-index/admin-organization-index.component';
import { AdminOrganizationCreateComponent } from './feature/admin/admin-organization-create/admin-organization-create.component';
import { AdminOrganizationUpdateComponent } from './feature/admin/admin-organization-update/admin-organization-add.component';
import { AdminProgramIndexComponent } from './feature/admin/admin-program-index/admin-program-index.component';
import { AdminProgramCreateComponent } from './feature/admin/admin-program-create/admin-program-create.component';
import { AdminProgramUpdateComponent } from './feature/admin/admin-program-update/admin-program-add.component';
import { AdminNavBarComponent } from './core/component/admin-component/admin-nav-bar/admin-nav-bar.component';
import { DpPaymentResponseComponent } from './core/component/detail-program/dp-payment-response/dp-payment-response.component';
import { AdminUserIndexComponent } from './feature/admin/admin-user-index/admin-user-index.component';
import { ChangePasswordPageComponent } from './feature/user/forgot-password-page/forgot-password-page.component';

const routes: Routes = [
  //User path
  { path: '', redirectTo: 'trai-tim-momo', pathMatch: 'full' },
  {
    path: 'trai-tim-momo',
    component: UserMainPageComponent,
  },
  {
    path: 'trai-tim-momo/login',
    component: LoginPageComponent,
  },
  {
    path: 'trai-tim-momo/register',
    component: RegisterPageComponent,
  },
  {
    path: 'trai-tim-momo/changepassword',
    component: ChangePasswordPageComponent,
  },
  {
    path: 'hoan-canh-quyen-gop',
    component: UserHcqgPageComponent,
  },
  {
    path: 'hoan-canh-quyen-gop/:category', // Add category parameter here
    component: UserHcqgPageComponent,
  },
  {
    path: 'hoan-canh-quyen-gop/details/:urlSlug', // Add urlSlug parameter here
    component: UserDetailProgramPageComponent,
  },
  {
    path: 'payment-response/:return-url',
    component: DpPaymentResponseComponent,
  },
  {
    path: 'doi-tac-dong-hanh',
    component: UserDtdhPageComponent,
  },
  {
    path: 'doi-tac-dong-hanh/details/:organizationFundraiseId',
    component: UserDetailDtdhPageComponent,
  },
  {
    path: 'trai-tim-momo/lich-su-quyen-gop',
    component: UserDonateHistoryComponent,
  },
  //Admin path

  {
    path: 'admin/organization',
    component: AdminOrganizationIndexComponent,
  },

  {
    path: 'admin/organization/create',
    component: AdminOrganizationCreateComponent,
  },
  {
    path: 'admin/organization/update/:id',
    component: AdminOrganizationUpdateComponent,
  },
  {
    path: 'admin/program',
    component: AdminProgramIndexComponent,
  },

  {
    path: 'admin/program/create',
    component: AdminProgramCreateComponent,
  },
  {
    path: 'admin/program/update/:id',
    component: AdminProgramUpdateComponent,
  },
  {
    path: 'admin/user',
    component: AdminUserIndexComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
