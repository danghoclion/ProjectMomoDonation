import { Component, Input } from '@angular/core';
import { DonationProgramModel } from 'src/app/feature/user/model/donation-program.model';

@Component({
  selector: 'app-dp-story',
  templateUrl: './dp-story.component.html',
  styleUrls: ['./dp-story.component.css'],
})
export class DpStoryComponent {
  @Input() donationProgram: DonationProgramModel;
}
