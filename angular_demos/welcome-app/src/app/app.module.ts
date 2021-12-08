import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { WelcomeComponent } from './welcome.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { SpinnerComponent } from './spinner/spinner.component';
import { GreetComponent } from './greet/greet.component';
import { DiscountComponent } from './discount/discount.component';
import { LppoingComponent } from './looping/looping.component';

@NgModule({
  declarations: [
    WelcomeComponent,
    HeaderComponent,
    FooterComponent,
    SpinnerComponent,
    GreetComponent,
    DiscountComponent,
    LppoingComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [WelcomeComponent]
})
export class AppModule { }
