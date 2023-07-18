import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TodoListItemModel } from 'src/app/models';

@Component({
  selector: 'app-todo-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css'],
})
export class TodoListComponent {
   @Input({required: true}) list: TodoListItemModel[] = [];
}
