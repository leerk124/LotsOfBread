using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LotsofBread.Models;
using Microsoft.AspNetCore.Authorization;

namespace LotsofBread.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository repository;
        private Cart cart;
        public OrderController(IOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }



        [Authorize]
        public ViewResult List() => View(repository.Orders.Where(o => !o.Shipped));


        [HttpPost]
        [Authorize]
        public IActionResult MarkShipped(int orderID)
        {
            Order order = repository.Orders
                    .FirstOrDefault(o => o.OrderID == orderID);
            if (order != null)
            {
                order.Shipped = true;
                repository.SaveOrder(order);
            }
            return RedirectToAction(nameof(List));
        }

        [Authorize]
        public IActionResult CheckoutForm() {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            // if (ModelState.IsValid) {
                System.Console.WriteLine($"Checkout 1");
                return View("Checkout", new Order());
            // }
            // System.Console.WriteLine($"Redirect Back");
            // return Page();//RedirectToAction("Index", "Cart");//View("Cart");
        }

        [Authorize]
        public IActionResult Confirmation(Order order) {
            // foreach (var a in order.Lines) {
            //     System.Console.WriteLine(a);
            // }
            // System.Console.WriteLine("BALLS");
            // return View();//View("Confirmation", order);
            
            System.Console.WriteLine($"Confirmation");
            if (ModelState.IsValid)
            {
                order.Lines = cart.Lines.ToArray();
                // repository.SaveOrder(order);
                return View("Confirmation", order);
            }
            else
            {
                return View(order);
            }
        }

        // [Authorize]
        // public ViewResult CheckoutFinal() {
        //     if (cart.Lines.Count() == 0)
        //     {
        //         ModelState.AddModelError("", "Sorry, your cart is empty!");
        //     }
        //     if (ModelState.IsValid)
        //     {
        //         return View(new Order());
        //     }
        //     else
        //     {
        //         return View(order);
        //     }
        // }

        [Authorize]
        [HttpPost]
        public IActionResult CheckoutFinal(Order order)
        {
            System.Console.WriteLine($"Checkout 2");
            // if (ModelState.IsValid)
            // {
            //     order.Lines = cart.Lines.ToArray();
                // return RedirectToAction(nameof(Completed));
                return View("Completed", order);
            // }
            // else
            // {
            //     return View(order);
            // }
        }
        public ViewResult Completed()
        {
            cart.Clear();
            return View(repository.Orders);

        }
    }
}
