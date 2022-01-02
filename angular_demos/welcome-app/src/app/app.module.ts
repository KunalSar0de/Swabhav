import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { WelcomeComponent } from './welcome.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { SpinnerComponent } from './spinner/spinner.component';
import { GreetComponent } from './greet/greet.component';
import { DiscountComponent } from './discount/discount.component';
import { LppoingComponent } from './looping/looping.component';
import { StudentComponent } from './student/student.component';
import { SnakeCasePipe } from './snake-case.pipe';
import { StudentassComponent } from './studentass/studentass.component';
import { RowcolorPipe } from './rowcolor.pipe';
import { ProductItemComponent } from './products/product-item.commponent';
import { ProductListComponent } from './products/product-list.component';
import { ProductService } from './products/product.service';
import { StarComponent } from './star/star.component';
import { ThumbnailComponent } from './thumbnail/thumbnail.component';
import { NumberApiComponent } from './number-api/number-api.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    WelcomeComponent,
    HeaderComponent,
    FooterComponent,
    SpinnerComponent,
    GreetComponent,
    DiscountComponent,
    LppoingComponent,
    StudentComponent,
    SnakeCasePipe,
    StudentassComponent,
    RowcolorPipe,
    ProductItemComponent,
    ProductListComponent,
    StarComponent,
    ThumbnailComponent,
    NumberApiComponent
 
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [ProductService],
  bootstrap: [WelcomeComponent]
})
export class AppModule { }
