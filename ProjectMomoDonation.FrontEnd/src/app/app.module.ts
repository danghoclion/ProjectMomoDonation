import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { MainPageComponent } from './core/component/main/main-page/main-page.component';
import { UserMainPageComponent } from './feature/user/user-main-page/user-main-page.component';
import { MainNavigationBarComponent } from './core/component/main/main-navigation-bar/main-navigation-bar.component';
import { MainBannerComponent } from './core/component/main/main-banner/main-banner.component';
import { MainDonationProgramComponent } from './core/component/main/main-donation-program/main-donation-program.component';
import { MainDonationProgramItemComponent } from './core/component/main/main-donation-program-item/main-donation-program-item.component';
import { MainOrganizationFundraiseComponent } from './core/component/main/main-organization-fundraise/main-organization-fundraise.component';

import { MainOrganizationFundraiseItemComponent } from './core/component/main/main-organization-fundraise-item/main-organization-fundraise-item.component';
import { MainQuestionComponent } from './core/component/main/main-question/main-question.component';
import { MainFooterComponent } from './core/component/main/main-footer/main-footer.component';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { DonationProgramService } from './feature/user/services/donation-program-service.service';
import { HcqgDonationProgramComponent } from './core/component/hoan-canh-quyen-gop/hcqg-donation-program/hcqg-donation-program.component';
import { UserHcqgPageComponent } from './feature/user/user-hcqg-page/user-hcqg-page.component';
// import function to register Swiper custom elements
import { register } from 'swiper/element/bundle';
import { HcqgCategoryFilterComponent } from './core/component/hoan-canh-quyen-gop/hcqg-category-filter/hcqg-category-filter.component';
import { UserDtdhPageComponent } from './feature/user/user-dtdh-page/user-dtdh-page.component';
import { DtdhOrganizationComponent } from './core/component/doi-tac-dong-hanh/dtdh-organization/dtdh-organization.component';
import { DtdhLastestPostComponent } from './core/component/doi-tac-dong-hanh/dtdh-lastest-post/dtdh-lastest-post.component';
import { UserDetailProgramPageComponent } from './feature/user/user-detail-program-page/user-detail-program-page.component';
import { DpBannerComponent } from './core/component/detail-program/dp-banner/dp-banner.component';
import { DpStoryComponent } from './core/component/detail-program/dp-story/dp-story.component';
import { DpDonatorListComponent } from './core/component/detail-program/dp-donator-list/dp-donator-list.component';
import { DdProgramListComponent } from './core/component/detail-dtdh/dd-program-list/dd-program-list.component';
import { UserDetailDtdhPageComponent } from './feature/user/user-detail-dtdh-page/user-detail-dtdh-page.component';
import { LoginPageComponent } from './feature/user/login-page/login-page.component';
import { DhInformationComponent } from './core/component/donate-history/dh-information/dh-information.component';
import { DhDonateListComponent } from './core/component/donate-history/dh-donate-list/dh-donate-list.component';
import { UserDonateHistoryComponent } from './feature/user/user-donate-history/user-donate-history.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { MatSelectModule } from '@angular/material/select';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatButtonModule } from '@angular/material/button';
import { RegisterPageComponent } from './feature/user/register-page/register-page.component';
import { AdminOrganizationUpdateComponent } from './feature/admin/admin-organization-update/admin-organization-add.component';
import { AdminOrganizationCreateComponent } from './feature/admin/admin-organization-create/admin-organization-create.component';
import { AdminProgramUpdateComponent } from './feature/admin/admin-program-update/admin-program-add.component';
import { AdminProgramCreateComponent } from './feature/admin/admin-program-create/admin-program-create.component';
import { AdminProgramIndexComponent } from './feature/admin/admin-program-index/admin-program-index.component';
import { AdminOrganizationIndexComponent } from './feature/admin/admin-organization-index/admin-organization-index.component';
import { AdminNavBarComponent } from './core/component/admin-component/admin-nav-bar/admin-nav-bar.component';
import { CKEditorModule } from '@ckeditor/ckeditor5-angular';
import { DatePipe } from '@angular/common';
import { DpPaymentResponseComponent } from './core/component/detail-program/dp-payment-response/dp-payment-response.component';
import { AdminUserIndexComponent } from './feature/admin/admin-user-index/admin-user-index.component';
import { ChangePasswordPageComponent } from './feature/user/forgot-password-page/forgot-password-page.component';
import { ForgotPasswordModalComponent } from './core/component/popup-modal/forgot-password-modal/forgot-password-modal.component';
// register Swiper custom elements
register();
@NgModule({
  declarations: [
    AppComponent,
    MainPageComponent,
    UserMainPageComponent,
    MainNavigationBarComponent,
    MainBannerComponent,
    MainDonationProgramComponent,
    MainDonationProgramItemComponent,
    MainOrganizationFundraiseComponent,
    MainOrganizationFundraiseItemComponent,
    MainQuestionComponent,
    MainFooterComponent,
    HcqgDonationProgramComponent,
    UserHcqgPageComponent,
    HcqgCategoryFilterComponent,
    UserDtdhPageComponent,
    DtdhOrganizationComponent,
    DtdhLastestPostComponent,
    UserDetailProgramPageComponent,
    DpBannerComponent,
    DpStoryComponent,
    DpDonatorListComponent,
    DdProgramListComponent,
    UserDetailDtdhPageComponent,
    LoginPageComponent,
    DhInformationComponent,
    DhDonateListComponent,
    UserDonateHistoryComponent,
    RegisterPageComponent,
    AdminOrganizationUpdateComponent,
    AdminOrganizationCreateComponent,
    AdminProgramUpdateComponent,
    AdminProgramCreateComponent,
    AdminProgramIndexComponent,
    AdminOrganizationIndexComponent,
    AdminNavBarComponent,
    DpPaymentResponseComponent,
    AdminUserIndexComponent,
    ChangePasswordPageComponent,
    ForgotPasswordModalComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatPaginatorModule,
    MatSnackBarModule,
    MatSidenavModule,
    MatSelectModule,
    MatInputModule,
    MatFormFieldModule,
    CKEditorModule,
    DatePipe,
    MatDialogModule,
    MatButtonModule,
    MatDatepickerModule,
    MatNativeDateModule
  ],
  providers: [DonationProgramService],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class AppModule {}
