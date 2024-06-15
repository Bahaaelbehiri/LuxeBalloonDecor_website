import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})
export class ServicesComponent implements OnInit {
  services = [
    {
      title: 'Balloon Arch',
      image: '../../../assets/images/ServicesItems/gallery21.jpg',
      description: `A balloon arch can take your event to the next level! Balloon arches can be used to: create an entrance/walkway, mark the location of a race, draw attention to something special, and much more!<br>Standard (12’ minimum): 11” balloons, up to 2 colors - $15/foot<br>Organic (12’ minimum): 5”, 11”, & 18” balloons, up to 3 colors - $20/foot`,
      details: [
        'Installation fee: 18% of subtotal',
        '+taxes and delivery',
        'Additional sizes, colors, and specialty balloons available to add-on for an additional fee.'
      ]
    },
    {
      title: 'Organic Balloon Garland',
      image: '../../../assets/images/ServicesItems/gallery-HomeImage.jpg',
      description: `Organic balloon garlands are a combination of different size, texture, and color balloons. If you want a luxe garland, then we can spice it up with artificial flowers, pampas grass, jewels, and more! Set the mood of your event with an organic balloon garland!<br>Organic garland (12’ minimum): 5”, 11”, & 18” balloons, up to 3 colors - $20/foot`,
      details: [
        'Installation fee: 18% of subtotal',
        '+taxes and delivery',
        'Additional sizes, colors, and specialty balloons available to add-on for an additional fee.'
      ]
    },
    {
      title: 'Balloon Columns',
      image: '../../../assets/images/ServicesItems/gallery16.jpg',
      description: `Add some pizzazz to the entrance or throughout your event with balloon columns! Columns are visually striking and versatile. Choose the perfect height ranging between 5’ and 7’.<br>Standard, single: $60<br>Standard, pair: $100<br>Organic, single: $100 (shown in photo)<br>Organic, pair: $175`,
      details: [
        'Installation fee: 18% of subtotal',
        '+tax and delivery',
        'Additional sizes, colors, and specialty balloons available to add-on for an additional fee.'
      ]
    },
    {
      title: 'Balloon Wall',
      image: '../../../assets/images/ServicesItems/gallery28.jpg',
      description: `Need an Instagram worthy photo backdrop?! Then you need a luxurious balloon wall! A balloon wall can accommodate any event theme. These unique design concepts can be the centerpiece or accent piece at your next event.<br>5”, 11”, & 18” balloons, up to 3 colors<br>6’ H x 5’ W: $400<br>8’ H x 8’ W: $580`,
      details: [
        'Installation fee: 18% of subtotal',
        '+tax and delivery',
        'Additional sizes, colors, and specialty balloons available to add-on for an additional fee.'
      ]
    },
    {
      title: 'Half Balloon Hoop',
      image: '../../../assets/images/ServicesItems/gallery2.jpg',
      description: `Strike a pose in front of this half hoop balloon garland!<br>White hoop dimension: 6.2 ft.<br>Gold hoop dimension: 7.2 ft.<br>Half circle, organic: 5”, 11”, & 18” balloons, up to 3 colors - $320 (6.2ft) and $340 (7.2ft)`,
      details: [
        'Installation fee: 18% of subtotal',
        '+taxes and delivery',
        'Additional sizes, colors, and specialty balloons available to add-on for an additional fee.'
      ]
    },
    {
      title: 'Full Balloon Hoop',
      image: '../../../assets/images/ServicesItems/gallery47.jpg',
      description: `Make a loud statement with a full hoop balloon garland!<br>White hoop dimension: 6.2 ft.<br>Gold hoop dimension: 7.2 ft.<br>Full circle, organic: 5”, 11”, & 18” balloons, up to 3 colors - $400 (6.2ft) and $420 (7.2ft)`,
      details: [
        'Installation fee: 18% of subtotal',
        '+taxes and delivery',
        'Additional sizes, colors, and specialty balloons available to add-on for an additional fee.'
      ]
    },
    {
      title: 'Balloon Ceiling',
      image: '../../../assets/images/ServicesItems/gallery17.jpg',
      description: `A whole vibe! A balloon ceiling elevates and sets the mood for an epic event!<br>5”, 11”, & 18” balloons, up to 3 colors.<br>Price depends on ceiling dimensions.`,
      details: [
        'Installation fee: 18% of subtotal',
        '+taxes and delivery',
        'Additional sizes, colors, and specialty balloons available to add-on for an additional fee.'
      ]
    },
    {
      title: 'Custom',
      image: '../../../assets/images/ServicesItems/gallery3.jpg',
      description: `Get creative with a custom balloon installation that fits your event needs! Custom designs such as a wedding dress decoration made entirely out of balloons.<br>Price depends on concept/design.`,
      details: [
        'Installation fee: 18% of subtotal',
        '+taxes and delivery',
        'Additional sizes, colors, and specialty balloons available to add-on for an additional fee.'
      ]
    }
  ];

  rentals = [
    {
      title: 'Balloon Hoop',
      image: '../../../assets/images/rentalItems/rentalItem1.jpg',
      description: 'White 6.2’ - $75',
      details: 'Gold 7.2’ - $100'
    },
    {
      title: 'Rectangle Backdrop',
      image: '../../../assets/images/rentalItems/rentalItem2.jpg',
      description: '$75',
      details: 'Dimensions: 6’ H x 6’ W or 10’ H x 10’ W'
    },
    {
      title: 'Round Top Arches',
      image: '../../../assets/images/rentalItems/rentalItem3.jpg',
      description: 'Gold set of three - $100',
      details: 'Dimensions: 4’ H x 1.7’ W, 5’ H x 2.2’ W, 6’ H x 2.6’ W'
    },
    {
      title: 'Circle Arch (Open Bottom)',
      image: '../../../assets/images/rentalItems/rentalItem4.jpg',
      description: '$75',
      details: 'White - 7.2’'
    },
    {
      title: 'White Square Backdrop',
      image: '../../../assets/images/rentalItems/rentalItem5.jpg',
      description: '$75',
      details: 'Dimensions: Up to 6.6’ x 6.6’'
    },
    {
      title: 'Cylinder Pedestal Stands',
      image: '../../../assets/images/rentalItems/rentalItem6.jpg',
      description: 'White set of three - $50',
      details: 'Dimensions: 23.5” H x 13” W, 29.5” H x 14” W, 35.5” H x 15.75” W'
    },
    {
      title: 'Silver Sequin Backdrop',
      image: '../../../assets/images/rentalItems/rentalItem7.jpg',
      description: '$75',
      details: 'Dimensions 6’ H x 6’ W'
    },
    {
      title: 'Faux Green Boxwood Backdrop',
      image: '../../../assets/images/rentalItems/rentalItem8.jpg',
      description: '$150',
      details: 'Dimensions: 7’ H x 7’ W'
    },
    {
      title: 'Custom Vinyl',
      image: '../../../assets/images/rentalItems/rentalItem9.jpg',
      description: 'Starting at $20',
      details: 'Custom vinyl can be added to our wooden arches, foam board arches, spandex arch slip covers, and so much more!'
    },
    {
      title: 'Rattan Fan Back Chair',
      image: '../../../assets/images/rentalItems/rentalItem10.jpg',
      description: '$75',
      details: 'Dimensions (Overall): 44” H x 30” W x 25.2” D<br>Seat Dimensions: 18” W x 19.25” D x 18” floor to seat top'
    },
    {
      title: 'Jute Boho Rug',
      image: '../../../assets/images/rentalItems/rentalItem11.jpg',
      description: '$40',
      details: '4ft, Round'
    },
    {
      title: 'Mr & Mrs Neon Sign',
      image: '../../../assets/images/rentalItems/rentalItem12.jpg',
      description: '$35',
      details: 'This neon sign is battery operated & has a dimmer switch<br>Color: White<br>Size: 23” W'
    },
    {
      title: 'Light Up Marquee Numbers/Letters',
      image: '../../../assets/images/rentalItems/rentalItem13.jpg',
      description: '$30 per number/letter',
      details: 'Numbers pictured are 4’ tall and light up with cool white lights.<br>Various options available.'
    },
    {
      title: 'Faux Florals',
      image: '../../../assets/images/rentalItems/rentalItem14.jpg',
      description: 'Starting at $50',
      details: 'Add an extra layer of texture to any balloon installation using artificial flowers, pampas grass, and much more!'
    },
    {
      title: 'Bedazzling',
      image: '../../../assets/images/rentalItems/rentalItem15.jpg',
      description: 'Starting at $15/balloon',
      details: 'If you can dream it, then we can put it on a balloon! Our limits are endless when it comes to bedazzling balloons with rhinestones, pearls, other types of jewels, glitter, and much more.'
    },
    {
      title: 'Balloon Clusters',
      image: '../../../assets/images/rentalItems/rentalItem16.jpg',
      description: '$15/cluster',
      details: 'Carry your theme throughout your event space with balloon clusters! Add balloon clusters to your order to spice it up.'
    },
    {
      title: 'Additional Services',
      image: '../../../assets/images/rentalItems/rentalItem17.jpg',
      description: 'Ask us about our additional event decorating and coordinating services!',
      details: ''
    },
    {
      title: 'Specialty Balloons',
      image: '../../../assets/images/rentalItems/rentalItem18.jpg',
      description: 'Specialty balloons available to add-on to any installation for an additional fee.',
      details: 'Specialty consists of balloons larger than 18”, mylar, metallic, confetti, and other fancy balloons!'
    }
  ];

  constructor() { }

  ngOnInit(): void {
  }
}
