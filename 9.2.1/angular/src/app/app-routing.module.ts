import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { TodosComponent } from './todos/todos.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                redirectTo: 'todos',
                pathMatch: 'full'
            },
            {
                path: 'todos',
                component: TodosComponent
            }
        ])
    ],
    exports: [RouterModule]
})
export class AppRoutingModule { }
