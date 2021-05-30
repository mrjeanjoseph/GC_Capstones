import { Post } from './../post';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-redditpost',
  templateUrl: './redditpost.component.html',
  styleUrls: ['./redditpost.component.css']
})
export class RedditpostComponent implements OnInit {
  @Input() reddit: Post = {
    title: "",
    image: "",
    link: "",
    //child_data: []
  }

  constructor() { }

  ngOnInit(): void {
  }

}
