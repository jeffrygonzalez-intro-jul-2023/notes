import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TodoEntryComponent } from "../../components/todo-entry/todo-entry.component";
import { TodoListComponent } from "../../components/todo-list/todo-list.component";
import { TodoListItemModel } from 'src/app/models';

@Component({
    selector: 'app-todos',
    standalone: true,
    templateUrl: './todos.component.html',
    styleUrls: ['./todos.component.css'],
    imports: [CommonModule, TodoEntryComponent, TodoListComponent]
})
export class TodosComponent {


    todoList:TodoListItemModel[] = [
        { id: '1', description: 'Buy Beer', isComplete: false },
    { id: '2', description: 'Clean Garage', isComplete: true },
    ];
    doIt(description:string) {
     const newTodoListItem:TodoListItemModel = {
        id: '99',
        description,
        isComplete: false
     }

     this.todoList = [newTodoListItem, ...this.todoList];
    }
}
