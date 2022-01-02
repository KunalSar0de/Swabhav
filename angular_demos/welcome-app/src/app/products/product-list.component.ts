import { Component, OnInit } from "@angular/core";
import { Product } from "./product";
import { ProductService } from "./product.service";


@Component({
    selector:'sw-product-list',
    template:`
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-alpha/css/bootstrap.min.css"/>
    <div class="container mt-3">
        <h3>Product List</h3>
        <label><b>Product Id : </b></label><input type="number" #pid>
        <label><b>Product Name :</b></label><input type="text" #pname>
        <label><b>Product rating :</b></label><input type="text" #pratings>
        <input type="Button" class="btn btn-primary" value="Add Item" (click)=AddInList(pid.value,pname.value,pratings.value)>
        <table class="table table-striped">
            <thead class="table-success">
                <td><b>Prod Id</b></td>
                <td><b>Prod Name</b></td>            
                <td><b>Prod Rating</b></td>            
            </thead>
            <tr *ngFor="let p of products" >
                <td>{{p.id}}</td>
                <td>{{p.name}}</td>
                <td>
                    <div style="overflow: hidden;"[style.width.px]="15*(p.rating+0.5)">
                        <div [style.width.px]="15*5" >
                        <span class="fa fa-star"></span>
                        <span class="fa fa-star"></span>
                        <span class="fa fa-star"></span>
                        <span class="fa fa-star"></span>
                        <span class="fa fa-star"></span>
                        </div>
                </div>
                </td>
            </tr>
        </table>

       
    </div>
    `
})
export class ProductListComponent implements OnInit{
    products:Array<Product>=new Array<Product>()

    constructor(private productService:ProductService){

    }
    ngOnInit() {
        this.products=this.productService.getProducts()
    }
    AddInList(id:string,name:string,rating:string){
        var num=parseInt(id);
        var rat=parseFloat(rating)
        console.log(id,name);
        if(id!=null || name!=null){
            this.products.push(new Product(num,name,rat));
        }   
    }
}