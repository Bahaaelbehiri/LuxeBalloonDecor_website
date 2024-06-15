import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-testimonials',
  templateUrl: './testimonials.component.html',
  styleUrls: ['./testimonials.component.css']
})
export class TestimonialsComponent implements OnInit {
  testimonials = [
    {
      title: 'Graduation Party',
      date: '06.03.2024',
      text: 'Regan and her sister helped us create beautiful balloon pieces for our daughter\'s graduation party. They were awesome to work with and easy to communicate with. I highly recommend them!',
      author: 'M. S.'
    },
    {
      title: 'Wedding Show',
      date: '03.10.2024',
      text: 'This duo at Luxe Balloons and Decor is both reliable and lovely to work with! They not only participated at the Tacoma Wedding Show, but provided balloon decor for signage at the entrance and around the event. Coordinating an event of this magnitude can get hectic, but including Regan and Hailey was easy - they took care of their part seamlessly. We highly recommend booking them!',
      author: 'N.K.'
    },
    {
      title: 'Birthday Party',
      date: '02.24.2024',
      text: 'Hailey and Regan did such an incredible job designing and installing a Flintstone themed balloon display for my daughter\'s second birthday! Blew our expectations out of the park!! They were professional, personable, and their communication was exceptional. It was a pleasure to work with such a creative company, will definitely hire again!',
      author: 'M. J.'
    },
    {
      title: 'Baby Shower',
      date: '02.19.2024',
      text: 'They created such a beautiful balloon display for my baby shower and were great to work with! Will definitely reach out the next time we are having an event!',
      author: 'M. A.'
    },
    {
      title: 'Baby Shower',
      date: '02.13.2024',
      text: 'I was extremely impressed with Luxe Balloons and Decor!! The process from getting a quote to installation was so easy! Regan and Hailey were so easy to work with and so quick with communication. I was able to choose the perfect colors for the ballon arch that was installed for a baby shower! Not only they created a beautiful ballon arch but also a customized wooden arch with the baby\'s name on it!! They offer more services and it\'s all worth it! I would definitely book again for any other future events and would recommend it to anyone who is looking for service as such!!! You would not be disappointed! Regan and Halley go above and beyond with their phenomenal work!',
      author: 'V. U.'
    },
    {
      title: 'Wedding',
      date: '01.24.2024',
      text: 'Was so happy that Luxe Balloons and Decor was able to assist with a last minute decision to set up a balloon and greenery arch for a wedding photo both. It was a boho theme and exceeded the brides expectations. Hailey was fun and easy to work. Would recommend them to anyone looking for something beautiful for a special event. Thank you!',
      author: 'K.J.'
    },
    {
      title: 'Ladies Night',
      date: '11.15.2023',
      text: 'Working with these ladies on my event was a blessing. I gave them a color scheme, showed where I wanted things placed and told them to run with their creativity. They sure ran with it! They are fun and energetic and their passion shows through their amazing work. Can\'t thank you enough and look forward to working with you in the future!',
      author: 'A. S.'
    },
    {
      title: 'Ghouls Night - Public Event',
      date: '10.21.2023',
      text: 'So many good things to say about Hailey and Regan! These two made my vision come to life by doing a huge ceiling balloon display for my Ghouls Night. It was more than I could have ever hoped for saved me so much time. I don\'t know what I would have done without these two. Highly recommend hiring Luxe Balloons & Decor for your next event big or small. It\'s worth every penny.',
      author: 'B. H.'
    },
    {
      title: 'Wedding Reception',
      date: '10.16.2023',
      text: 'I can\'t recommend Luxe Balloons & Decor enough!! I used them for my Bridal shower back in August and this weekend I used them again for my Wedding Reception Party. The attention to detail is phenomenal. I was absolutely blown away by how beautiful the balloon arch was! It was more than I could have ever envisioned for my husband and I\'s special day. I highly recommend using this business for any of your events, parties etc. TRUST ME you won\'t ever be disappointed you get so much more than what you pay for!',
      author: 'T.O.'
    },
    {
      title: 'Grand Opening',
      date: '10.16.2023',
      text: 'Luxe balloons & decor was a pleasure to work with! Great communication, on time and reliable! Perfectly making the balloons a VISION I highly recommend if you want to make your event top tier!',
      author: 'K. D.'
    },
    {
      title: 'Baby Shower',
      date: '10.15.2023',
      text: 'Working with Luxe Balloons and Decor was easy and I would highly recommend them for your balloon and party needs. Their team was very communicative, pleasant to deal with and the end product was better than we imagined. I thought the pricing was fair for the amount of work involved in balloon structures, delivery and pickup as well as the high quality balloons they use.',
      author: 'C. S.'
    },
    {
      title: 'Baby Shower',
      date: '9.18.2023',
      text: 'They did an incredible job for my baby shower. I was so impressed with how everything looked and the quality was top notch. You NEED them for your next event!',
      author: 'A. H.'
    },
    {
      title: 'Bridal Shower',
      date: '8.30.2023',
      text: 'I could not recommend Luxe Balloons and Decor enough! Their eye for detail is phenomenal. I was having a Bridal Shower event and when I sent a few photos of what I was looking for, I was not expecting for them to go above and beyond my expectations. I enjoyed working with Regan and Hailey to make my day so special. I can not wait to work them again they are such lovely people and truly make your events so magical!',
      author: 'T. W.'
    },
    {
      title: 'Public Event',
      date: '8.25.2023',
      text: 'Luxe Balloons & Decor went above and beyond for a ballon arch that was handmade for a public event. Can\'t wait to book them again for our events!',
      author: 'A. K.'
    }
  ];

  constructor() { }

  ngOnInit(): void {
  }
}
