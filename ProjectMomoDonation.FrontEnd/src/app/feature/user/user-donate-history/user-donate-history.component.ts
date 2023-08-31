import { Component,OnInit } from '@angular/core';
import { UserModel } from '../model/user.model';
import { AccountService } from '../services/account-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-donate-history',
  templateUrl: './user-donate-history.component.html',
  styleUrls: ['./user-donate-history.component.css']
})
export class UserDonateHistoryComponent implements OnInit {
user: UserModel;

constructor(private accountService : AccountService, private router : Router){}

  ngOnInit(): void {
    this.accountService.user()
    .subscribe({
      next: (response) => {
        this.user=response;
      }
    })
    this.user = this.accountService.getUser();

  }
}
