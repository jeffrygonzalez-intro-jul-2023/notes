import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-header2',
  standalone: true,
  imports: [CommonModule],
  template: `
    <p>
      header2 works!
    </p>
  `,
  styleUrls: ['./header2.component.css']
})
export class Header2Component {

}
