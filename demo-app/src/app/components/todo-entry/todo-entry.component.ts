import { Component, Output, EventEmitter } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-todo-entry',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './todo-entry.component.html',
  styleUrls: ['./todo-entry.component.css']
})
export class TodoEntryComponent {

  @Output() itemAdded = new EventEmitter<string>();

  addIt(description:HTMLInputElement) {
   
    this.itemAdded.emit(description.value);
    description.value = '';
  }
}
