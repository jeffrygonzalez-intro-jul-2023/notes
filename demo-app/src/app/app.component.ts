import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { DemoComponent } from "./components/demo/demo.component";
import { TodosComponent } from "./pages/todos/todos.component";

// "Metadata Decorators - Typescript"
// C# - Attributes [Component]
@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
    imports: [CommonModule, RouterOutlet, DemoComponent, TodosComponent]
})
export class AppComponent {
  title = 'demo-app';
}
