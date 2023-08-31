import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserModel } from 'src/app/feature/user/model/user.model';
import { AccountService } from 'src/app/feature/user/services/account-service.service';

@Component({
  selector: 'app-main-navigation-bar',
  templateUrl: './main-navigation-bar.component.html',
  styleUrls: ['./main-navigation-bar.component.css'],
})
export class MainNavigationBarComponent implements OnInit {
  user?: UserModel;
constructor(private accountService : AccountService, private router : Router){}

  ngOnInit(): void {
    this.accountService.user()
    .subscribe({
      next: (response) => {
        
        this.user=response;
        console.log(this.user)
      }
    })

    this.user = this.accountService.getUser();
  }
  mobileMenuOpen: boolean = false;

  toggleMobileMenu() {
    this.mobileMenuOpen = !this.mobileMenuOpen;
  }

  closeMobileMenu() {
    this.mobileMenuOpen = false;
  }
  onLogout(){
    this.accountService.logout();
    this.router.navigateByUrl('/');
  }
}
