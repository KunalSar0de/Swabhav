import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-thumbnail',
  templateUrl: './thumbnail.component.html',
  styleUrls: ['./thumbnail.component.css']
})
export class ThumbnailComponent implements OnInit {
  public mainImage:string="";
  isClear:boolean=true;
  images:any[] = [
    {name:"img1",url:"https://images.unsplash.com/photo-1638292596909-5174a9f6ec11?crop=entropy&cs=tinysrgb&fit=crop&fm=jpg&h=200&ixid=MnwxfDB8MXxyYW5kb218MHx8fHx8fHx8MTYzOTg5NDQ0MA&ixlib=rb-1.2.1&q=80&w=200"},
    {name:"img2",url:"https://images.unsplash.com/photo-1637397856694-f13e679ff6ac?crop=entropy&cs=tinysrgb&fit=crop&fm=jpg&h=200&ixid=MnwxfDB8MXxyYW5kb218MHx8fHx8fHx8MTYzOTg5NDc5NA&ixlib=rb-1.2.1&q=80&w=200"},
    {name:"img3",url:"https://images.unsplash.com/photo-1637594099860-f5464f7950b8?crop=entropy&cs=tinysrgb&fit=crop&fm=jpg&h=200&ixid=MnwxfDB8MXxyYW5kb218MHx8fHx8fHx8MTYzOTg5NDgyOQ&ixlib=rb-1.2.1&q=80&w=200"},
    {name:"img4",url:"https://images.unsplash.com/photo-1638210685796-2a95d078da4c?crop=entropy&cs=tinysrgb&fit=crop&fm=jpg&h=200&ixid=MnwxfDB8MXxyYW5kb218MHx8fHx8fHx8MTYzOTg5NDg2Nw&ixlib=rb-1.2.1&q=80&w=200"},
    {name:"img5",url:"https://images.unsplash.com/photo-1638190654504-0f3e627545ef?crop=entropy&cs=tinysrgb&fit=crop&fm=jpg&h=200&ixid=MnwxfDB8MXxyYW5kb218MHx8fHx8fHx8MTYzOTg5NjM0Ng&ixlib=rb-1.2.1&q=80&w=200"},
    
  ];
 
  constructor() {

  }
  changeMainImg(image:string){
    this.isClear=false;
    this.mainImage = image;
  }
  ClearImg(){
    this.isClear=true;
  }
  ngOnInit(): void {
  }

}

export class Images{
  constructor(name:string,url:string) {}
}


