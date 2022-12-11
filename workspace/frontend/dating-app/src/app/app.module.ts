import { NgModule } from '@angular/core'
import { BrowserModule } from '@angular/platform-browser'

import { AppComponent } from './app.component'

import { HttpClientModule } from '@angular/common/http'
import { AppNgBootstrapModule } from './app-ng-bootstrap.module'
import { AppFontawesomeModule } from './app-fontawesome.module'

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppNgBootstrapModule,
    AppFontawesomeModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
