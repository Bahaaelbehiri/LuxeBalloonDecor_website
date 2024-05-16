import { Component } from '@angular/core';

@Component({
  selector: 'app-navigation',
  templateUrl: './navigation.component.html',
  styleUrls: ['./navigation.component.css']
})
export class NavigationComponent {
  isMenuCollapsed = true;
  navLinks = [
    { title: 'Home', url: '/home'},
    { title: 'Services', url: '/services' },
    { title: 'Gallery', url: '/gallery' },
    { title: 'About', url: '/about' },
    { title: 'Contact', url: '/contact'},
    { title: 'Terms', url: '/terms' }
  ];

  socialLinks = [
    { icon: 'envelope', url: 'mailto:luxedecor2023@gmail.com' },
    { icon: 'instagram', url: 'https://www.instagram.com/luxe_balloons_and_decor/' },
    { icon: 'pinterest', url: 'https://www.pinterest.com/luxedecor2023' },
    { icon: 'facebook', url: 'https://www.facebook.com/profile.php?id=100095004403567' }
  ];

  constructor() {

  }
}
