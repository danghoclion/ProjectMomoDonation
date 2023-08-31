import { Component } from '@angular/core';
import { OrganizationFundraiseModel } from 'src/app/feature/user/model/organization-fundraise.model';
import { DonationProgramService } from 'src/app/feature/user/services/donation-program-service.service';

@Component({
  selector: 'app-main-organization-fundraise',
  templateUrl: './main-organization-fundraise.component.html',
  styleUrls: ['./main-organization-fundraise.component.css'],
})
export class MainOrganizationFundraiseComponent {
  breakpoints = {
    360: { slidesPerView: 1, spaceBetween: 10 },
    768: { slidesPerView: 2, spaceBetween: 15 },
    1024: { slidesPerView: 3, spaceBetween: 20 },
  };
  constructor(private donationProgramService: DonationProgramService) {}
  allOrganizationFundraise?: OrganizationFundraiseModel[];
  ngOnInit(): void {
    this.donationProgramService.getAllOrganizationFundraise().subscribe({
      next: (response) => {
        this.allOrganizationFundraise = response;
      },
    });
  }
}
