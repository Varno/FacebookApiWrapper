using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace FacebookApiWrapper.Web.Controllers
{
    //[RoutePrefix("api")]
    //public class SubscribersController : ApiController
    //{
    //    SubscriberRepositary repositary = new SubscriberRepositary();

    //    /// <summary>
    //    /// Get all subscribers
    //    /// </summary>
    //    /// <remarks>Get an array of all subscribers</remarks>
    //    /// <response code="500">Internal Server Error</response>
    //    [Route("Subscribers")]
    //    [ResponseType(typeof(List<Subscriber>))]
    //    public IHttpActionResult Get()
    //    {
    //        return Ok(repositary.GetList());
    //    }

    //    /// <summary>
    //    /// Get subscriber
    //    /// </summary>
    //    /// <param name="subscriberName">Unique subscriber name</param>
    //    /// <remarks>Get signle subscriber by providing name</remarks>
    //    /// <response code="404">Not found</response>
    //    /// <response code="500">Internal Server Error</response>
    //    [Route("SubscriberByName")]
    //    [ResponseType(typeof(Subscriber))]
    //    public IHttpActionResult Get(string subscriberName)
    //    {
    //        var subscriber = repositary
    //            .GetList(s => s.Name.Equals(subscriberName, StringComparison.OrdinalIgnoreCase))
    //            .FirstOrDefault();

    //        if (subscriber == null)
    //            return NotFound();

    //        return Ok(subscriber);
    //    }

    //    /// <summary>
    //    /// Add new subscriber
    //    /// </summary>
    //    /// <param name="name">The name.</param>
    //    /// <param name="groupIds">The group id collection (separetad by ','). </param>
    //    /// <returns></returns>
    //    /// <remarks>
    //    /// Insert new subscriber
    //    /// </remarks>
    //    /// <response code="400">Bad request</response>
    //    /// <response code="500">Internal Server Error</response>
    //    [Route("Subscriber")]
    //    [ResponseType(typeof(Subscriber))]
    //    public IHttpActionResult Post([FromUri]string name, [FromUri]IEnumerable<string> groupIds)
    //    {
    //        if (!ModelState.IsValid && !string.IsNullOrEmpty(name))
    //            return BadRequest(ModelState);

    //        var existSubscriber = repositary
    //            .GetList(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
    //            .FirstOrDefault();
    //        if (existSubscriber != null)
    //            return BadRequest("Subscriber already exists");

    //        var subscriber = Participant.Build<Subscriber>(name);
    //        repositary.Add(subscriber);
    //        return Created(new Uri("api/SubscriberByName", UriKind.Relative), subscriber);
    //    }

    //    ///// <summary>
    //    ///// Delete subscriber
    //    ///// </summary>
    //    ///// <param name="subscriberName">Unique subscriber name</param>
    //    ///// <remarks>Delete existing subscriber by name</remarks>
    //    ///// <response code="404">Not found</response>
    //    ///// <response code="500">Internal Server Error</response>
    //    //[Route("{userName:alpha}")]
    //    //public HttpResponseMessage Delete(string subscriberName)
    //    //{
    //    //    var subscriber = repositary
    //    //        .GetList(s => s.Name.Equals(subscriberName, StringComparison.OrdinalIgnoreCase))
    //    //        .FirstOrDefault();

    //    //    if (subscriber == null)
    //    //        return NotFound();

    //    //    repositary.Remove(subscriber);

    //    //    return Request.CreateResponse(HttpStatusCode.NoContent);

    //    //}
    //}
}
