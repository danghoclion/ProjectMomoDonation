import { Component, Input, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute } from '@angular/router';
import { empty } from 'rxjs';
import { DonateRequestModel } from 'src/app/feature/user/model/donate-request.model';
import { DonationResponseQueryParams } from 'src/app/feature/user/model/donate-response-query-params.model';
import { DonateResponseModel } from 'src/app/feature/user/model/donate-response.model';
import { DonationProgramModel } from 'src/app/feature/user/model/donation-program.model';
import { DonationProgramService } from 'src/app/feature/user/services/donation-program-service.service';

@Component({
  selector: 'app-dp-banner',
  templateUrl: './dp-banner.component.html',
  styleUrls: ['./dp-banner.component.css'],
})
export class DpBannerComponent implements OnInit {
  @Input() donationProgram: DonationProgramModel;
  donateRequest: DonateRequestModel;
  donateResponse: DonateResponseModel;
  donateBack: DonationResponseQueryParams;
  daysLeft: number;
  progressWidth: string;
  panelMaxHeight = '500px';
  expanded: boolean;

  constructor(
    private paymentService: DonationProgramService,
    private route: ActivatedRoute,
    private snackBar: MatSnackBar
  ) {}
  ngOnInit(): void {
    //Information Display
    const dateEnd = new Date(this.donationProgram.dateEnd);
    const dateStart = new Date(this.donationProgram.dateStart);
    const timeDiff = dateEnd.getTime() - new Date().getTime();
    this.daysLeft = Math.ceil(timeDiff / (1000 * 3600 * 24));
    const totalDonate = this.donationProgram.totalDonate;
    const goalDonate = this.donationProgram.donationGoal;
    this.progressWidth = ((totalDonate / goalDonate) * 100).toFixed(2) + '%';

    this.donateRequest = {
      money: null,
      userName: localStorage.getItem('user-name'),
      programId: this.donationProgram.id,
      urlRedirect: 'http://localhost:4200/payment-response/'+ this.donationProgram.urlSlug,
    };
  }
  toggleAccordion() {
    this.expanded = !this.expanded;
  }
  onConfirm() {
    //Create request
    console.log(this.donateRequest);
    this.paymentService.donateRequest(this.donateRequest).subscribe({
      next: (response) => {
        this.donateResponse = response;
        console.log(this.donateResponse);
        // Redirect to the provided payUrl
        window.location.href = this.donateResponse.payUrl;
      },
      error: (error) => {
        // Display success message
        this.snackBar.open(`Có lỗi xảy ra. Vui lòng thử lại sau`, 'Đóng', {
          duration: 2000,
          horizontalPosition: 'center',
          verticalPosition: 'top',
        });
      },
    });
  }
}
