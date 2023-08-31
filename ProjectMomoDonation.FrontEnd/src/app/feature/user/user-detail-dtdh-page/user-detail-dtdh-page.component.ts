import { Component, OnInit } from '@angular/core';
import { DonationProgramService } from '../services/donation-program-service.service';
import { ActivatedRoute } from '@angular/router';
import { OrganizationFundraiseModel } from '../model/organization-fundraise.model';
import { DonationProgramModel } from '../model/donation-program.model';
@Component({
  selector: 'app-user-detail-dtdh-page',
  templateUrl: './user-detail-dtdh-page.component.html',
  styleUrls: ['./user-detail-dtdh-page.component.css'],
})
export class UserDetailDtdhPageComponent implements OnInit {
  constructor(
    private donationProgramService: DonationProgramService,
    private route: ActivatedRoute
  ) {}
  Organization?: OrganizationFundraiseModel;
  organizationProgram?: DonationProgramModel[];
  id: string | null = null;

  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      this.id = params.get('organizationFundraiseId');
    });
    this.donationProgramService
      .getOrganizationFundraiseById(this.id)
      .subscribe({
        next: (response) => {
          this.Organization = response;
        },
      });
    this.donationProgramService
      .getProgramListByOrganizationId(this.id)
      .subscribe({
        next: (response) => {
          this.organizationProgram = response;
        },
      });
  }
}
