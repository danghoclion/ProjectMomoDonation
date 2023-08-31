import { Component, Input } from '@angular/core';
import { DonationProgramModel } from 'src/app/feature/user/model/donation-program.model';
import { OrganizationFundraiseModel } from 'src/app/feature/user/model/organization-fundraise.model';

@Component({
  selector: 'app-dd-program-list',
  templateUrl: './dd-program-list.component.html',
  styleUrls: ['./dd-program-list.component.css'],
})
export class DdProgramListComponent {
  @Input() organizationProgram: DonationProgramModel;
  @Input() organization: OrganizationFundraiseModel;
  breakpoints = {
    360: { slidesPerView: 1, spaceBetween: 20 },
    768: { slidesPerView: 2, spaceBetween: 40 },
    1024: { slidesPerView: 3, spaceBetween: 50 },
  };
}
