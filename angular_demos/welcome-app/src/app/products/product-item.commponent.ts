import { Component, OnInit } from "@angular/core";
import { Product } from "./product";
import { ProductService } from "./product.service";

@Component({
    selector:'sw-product-item',
    template:`
    <div class="mt-4 p-5 bg-primary text-white rounded">
        <h1>Product Item</h1>
        <h2>{{product.id}}--{{product.name}}</h2><br>
        <input type="button" class="btn btn-warning" value="Test Button"/>
    </div>
    `
})
export class ProductItemComponent implements OnInit{
    product:Product=new Product(0,"",1)

    constructor(private productService:ProductService){

    }
    ngOnInit() {
        this.product=this.productService.getMaxSoldProducts()
    }
}