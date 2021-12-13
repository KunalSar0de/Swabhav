import { Component, OnInit } from "@angular/core";
import { NumberValueAccessor } from "@angular/forms";
import { Product } from "./product";
import { ProductService } from "./product.service";


@Component({
    selector:'sw-product-list',
    template:`
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-alpha/css/bootstrap.min.css"/>
    <div class="container mt-3">
        <h1>Product List</h1>
        <label>Product Id</label><input type="text" #pid>
        <label>Product Name</label><input type="text" #pname>
        <input type="Button" value="Add Item" (click)=AddInList(pid.value,pname.value)>
        <table class="table table-striped">
            <thead class="table-success">
                <td><b>Prod Id</b></td>
                <td><b>Prod Name</b></td>            
            </thead>
            <tr *ngFor="let p of products" >
                <td>{{p.id}}</td>
                <td>{{p.name}}</td>
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
    AddInList(id:string,name:string){
        var num=parseInt(id);
        console.log(id,name);
        
    }
}