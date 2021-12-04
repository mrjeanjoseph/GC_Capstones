import { PostapiService } from './../postapi.service';
import { Component, OnInit } from '@angular/core';
import { Post } from '../post';


@Component({
  selector: 'app-reddithome',
  templateUrl: './reddithome.component.html',
  styleUrls: ['./reddithome.component.css']
})
export class ReddithomeComponent implements OnInit {
  redditData: Post[] = [];
  kind: string = "";
  
  constructor(private postapiservice: PostapiService) { }

  ngOnInit(): void {
    this.GetAllPost();
  }

  //Notice that I have to create this method then call it above.
  GetAllPost():void{
    this.postapiservice.getReddit().subscribe(
      (response:any) =>{
        response.data.children.forEach((singlePost: { data: { title: any; thumbnail: any; url: any; }; }) => {
          //grab other values
          let newPost:Post={
            title:singlePost.data.title,
            image:singlePost.data.thumbnail,
            link:singlePost.data.url // I hope you don't mind me using the URL instead
          }
          this.redditData.push(newPost);
        });
        console.log(response);
      }
    )
  }
}
