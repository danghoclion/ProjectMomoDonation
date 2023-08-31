import { Component, Input, OnInit } from '@angular/core';
import { OrganizationFundraiseModel } from 'src/app/feature/user/model/organization-fundraise.model';
// import Swiper bundle with all modules installed

@Component({
  selector: 'app-main-organization-fundraise-item',
  templateUrl: './main-organization-fundraise-item.component.html',
  styleUrls: ['./main-organization-fundraise-item.component.css'],
})
export class MainOrganizationFundraiseItemComponent implements OnInit {
  @Input() OrganizationFundraise: OrganizationFundraiseModel;
  ngOnInit(): void {}
}
