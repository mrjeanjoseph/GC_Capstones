import { Todo } from './../todo';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  initialList:Todo[] = [
    {
      task: "Go to Gym at 7:00AM",
      completed: false
    },
    {
      task: "Prepare for work at 8:30",
      completed: false
    },
    {
      task: "Meeting at 11:15AM",
      completed: false
    },
    
    {
      task: "Dinner tonight at 6:PM",
      completed: false
    },
    {
      task: "Be Awesome",
      completed: true
    },
  ];

  // UpdateTaskItem(form: NgForm):boolean{
  //   let updatedTask:Todo = {
  //     task: form.form.value.task,
  //   }
  // }

  completedTask(form: NgForm): void{
    this.initialList[form.form.value.completed].completed = true;
  }

  AddTask(form: NgForm):void {
    let newTask:Todo = {
      task: form.form.value.task, // remember to call task in html name
      completed: false
    };
    this.initialList.push(newTask);
  }
}