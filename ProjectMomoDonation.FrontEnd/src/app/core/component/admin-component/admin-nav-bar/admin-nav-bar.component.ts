import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AccountService } from 'src/app/feature/user/services/account-service.service';

@Component({
  selector: 'app-admin-nav-bar',
  templateUrl: './admin-nav-bar.component.html',
  styleUrls: ['./admin-nav-bar.component.css']
})
export class AdminNavBarComponent {
  constructor(private accountService : AccountService, private router : Router){}
  mobileMenuOpen: boolean = false;

  toggleMobileMenu() {
    this.mobileMenuOpen = !this.mobileMenuOpen;
  }

  closeMobileMenu() {
    this.mobileMenuOpen = false;
  }
  onLogout(){
    this.accountService.logout();
    this.router.navigateByUrl('/trai-tim-momo');
  }
}
