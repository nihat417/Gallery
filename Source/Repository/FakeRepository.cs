using Source.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Repository;

public class FakeRepository
{
    public static List<ImageCl> images = new ()
    {
        new ImageCl(){ ImageUrl="/StaticFiles/Images/img1.jpg"},
        new ImageCl(){ ImageUrl="/StaticFiles/Images/im1.jpg"},
        new ImageCl(){ ImageUrl="/StaticFiles/Images/im2.jpg"},
        new ImageCl(){ ImageUrl="/StaticFiles/Images/im3.jpg"},
        new ImageCl(){ ImageUrl="/StaticFiles/Images/im5.jpg"},
        new ImageCl(){ ImageUrl="/StaticFiles/Images/im5.jpg"},
        new ImageCl(){ ImageUrl="/StaticFiles/Images/im5.jpg"},
        new ImageCl(){ ImageUrl="/StaticFiles/Images/im5.jpg"},

    };
}
//