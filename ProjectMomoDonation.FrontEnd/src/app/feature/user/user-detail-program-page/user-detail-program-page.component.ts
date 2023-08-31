import { Component, OnInit } from '@angular/core';
import { DonationProgramService } from '../services/donation-program-service.service';
import { DonationProgramModel } from '../model/donation-program.model';
import { ActivatedRoute } from '@angular/router';
import { AccountService } from '../services/account-service.service';
import { UserModel } from '../model/user.model';
import { DonateHistoryModel } from '../model/donate-history.model';
import { PaymentResponsemodel } from '../model/payment-response.model';
@Component({
  selector: 'app-user-detail-program-page',
  templateUrl: './user-detail-program-page.component.html',
  styleUrls: ['./user-detail-program-page.component.css'],
})
export class UserDetailProgramPageComponent implements OnInit {
  jsonResponseString : string

   parsedResponse : PaymentResponsemodel
  constructor(
    private donationProgramService: DonationProgramService,
    private accountService : AccountService,
    private route: ActivatedRoute
  ) {}
  DonationProgram?: DonationProgramModel;
  user? : UserModel;
  urlSlug: string | null = null;
  donateList : DonateHistoryModel[];
  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      this.urlSlug = params.get('urlSlug');
    });
    this.donationProgramService
      .getDonationProgramByUrlSlug(this.urlSlug)
      .subscribe({
        next: (response) => {
          this.DonationProgram = response;
        },
      });
      
      this.accountService.user()
    .subscribe({
      next: (response) => {
        this.user=response;
      }
    })

    this.user = this.accountService.getUser();
    this.donationProgramService.getDonateListByUrlSlugProgram(this.urlSlug)
    .subscribe({
      next: (response) => {
        this.donateList = response
        
      }
    })
  }
}
