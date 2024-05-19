import { Component, OnInit, TemplateRef, ViewChild } from '@angular/core';
import { TodoService } from '../todo.service';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
})
export class TodosComponent implements OnInit {
  todos: any[] = [];
  description: string;
  isSubmitted: boolean;
  modalRef: BsModalRef;
  @ViewChild('addToDo') addToDoModal!: TemplateRef<any>;
  
  constructor(private todoService: TodoService,
            private modalService: BsModalService
          ) { }

  ngOnInit(): void {
    this.loadTodos();
  }

  loadTodos(): void {
    this.todoService.getAll().subscribe(data => {
      this.todos = data.result;
    });
  }

  createTodo(): void {
		this.isSubmitted = true;
    const newTodo = { description: this.description };
    if (this.description) {
			this.todoService.create(newTodo).subscribe(() => {
        this.closeModal()
        this.loadTodos();
			});
		}
  }

  closeModal() {
		this.modalRef.hide();
		this.isSubmitted = false;
		this.description = '';
	}

  updateTodo(id: any, status: boolean): void {
    var todoo = this.todos.find(_ => _.id == id);
    todoo.isCompleted = status;
    this.todoService.update(todoo).subscribe(() => {
      this.loadTodos();
    });
  }

  AddToDo() {
		this.modalRef = this.modalService.show(this.addToDoModal, { class: 'modal-lg', ignoreBackdropClick: true })
	}

  deleteTodo(id: number): void {
    this.todoService.delete(id).subscribe(() => {
      this.loadTodos();
    });
  }
}
