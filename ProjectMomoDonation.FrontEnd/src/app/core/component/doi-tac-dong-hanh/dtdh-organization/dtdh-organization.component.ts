import { Component } from '@angular/core';
import { OrganizationFundraiseModel } from 'src/app/feature/user/model/organization-fundraise.model';
import { DonationProgramService } from 'src/app/feature/user/services/donation-program-service.service';

@Component({
  selector: 'app-dtdh-organization',
  templateUrl: './dtdh-organization.component.html',
  styleUrls: ['./dtdh-organization.component.css'],
})
export class DtdhOrganizationComponent {
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
