using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tipsy.Models.PaymentModels;
using Tipsy.Services;

namespace Tipsy.WebAPI.Controllers
{
    [Authorize]
    public class PaymentController : ApiController
    {
        private PaymentService CreatePaymentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var paymentService = new PaymentService(userId);
            return paymentService;
        }

        public IHttpActionResult Get()
        {
            PaymentService paymentService = CreatePaymentService();
            var payment = paymentService.GetPayments();
            return Ok(payment);
        }

        public IHttpActionResult Post(PaymentCreate payment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePaymentService();

            if (!service.CreatePayment(payment))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            PaymentService paymentService = CreatePaymentService();
            var payment = paymentService.GetPaymentById(id);
            return Ok(payment);
        }

        public IHttpActionResult put(PaymentEdit payment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePaymentService();

            if (!service.UpdatePayment(payment))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreatePaymentService();

            if (!service.DeletePayment(id))
                return InternalServerError();

            return Ok();
        }
    }
}
