import { Component, Output, EventEmitter, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-searchform',
  templateUrl: './searchform.component.html',
  styleUrls: ['./searchform.component.css']
})
export class SearchformComponent implements OnInit {
  @Output() submitsearch = new EventEmitter<string>();
  constructor() { }

  ngOnInit(): void {
  }
  submitSearch(form: NgForm): void {
    let searchTerm:string = form.form.value.Type;
    this.submitsearch.emit(searchTerm);
  }
}
