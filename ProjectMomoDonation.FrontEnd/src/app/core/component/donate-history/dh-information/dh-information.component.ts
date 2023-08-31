import { Component, Input } from '@angular/core';
import { UserModel } from 'src/app/feature/user/model/user.model';

@Component({
  selector: 'app-dh-information',
  templateUrl: './dh-information.component.html',
  styleUrls: ['./dh-information.component.css']
})
export class DhInformationComponent {
  @Input() user : UserModel
}
