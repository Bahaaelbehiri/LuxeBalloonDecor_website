import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { NavigationComponent } from './navigation/navigation.component';
import { HomeComponent } from './home/home.component';
import { ServicesComponent } from './services/services.component';
import { GalleryComponent } from './gallery/gallery.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { TermsComponent } from './terms/terms.component';
import { RouterModule, Routes } from '@angular/router';
import { CardComponent } from './cards/card/card.component';
import { LandingCarouselComponent } from './landing-carousel/landing-carousel.component';
import { FooterComponent } from './footer/footer.component';
import { TestimonialsComponent } from './testimonials/testimonials.component';
import { ServiceItemComponent } from './service-item/service-item.component';
import { RentalItemComponent } from './rental-item/rental-item.component';


const routes: Routes = [
  { path: 'home', redirectTo: '', pathMatch:'full'},
  { path: '', component: HomeComponent },
  { path: 'services', component: ServicesComponent },
  { path: 'gallery', component: GalleryComponent },
  { path: 'about', component: AboutComponent },
  { path: 'contact', component: ContactComponent },
  { path: 'terms', component: TermsComponent },
  { path: 'landing-carousel', component: LandingCarouselComponent },
  { path: 'footer', component: FooterComponent }

]

@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    LandingCarouselComponent,
    ServicesComponent,
    GalleryComponent,
    AboutComponent,
    ContactComponent,
    TermsComponent,
    CardComponent,
    HomeComponent,
    FooterComponent,
    TestimonialsComponent,
    ServiceItemComponent,
    RentalItemComponent

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
