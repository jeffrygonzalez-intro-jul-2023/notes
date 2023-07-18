import { Component } from '@angular/core';
import { CommonModule, NgFor } from '@angular/common';

@Component({
  selector: 'app-demo',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent {
  title = 'Demo Component';

  friends = ['Sean', 'David', 'Lee', 'Jamie'];

  unFriend(name: string) {
    this.friends = this.friends.filter(n => n != name );
  }

  addFriend(name: HTMLInputElement) {
    this.friends = [name.value, ...this.friends];
    name.value = '';
  }
}
