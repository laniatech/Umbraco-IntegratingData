﻿using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Website.Sample.PublishedContentModels;

namespace Website.Sample.ExternalData
{
    public class PersonController : RenderMvcController
    {
        private readonly PersonRepository _personRepository;

        public PersonController()
        {
            _personRepository = new PersonRepository();
        }

        // GET: Person
        public ActionResult Details(RenderModel model, string slug)
        {
            if (model?.Content == null || slug == null)
            {
                return HttpNotFound();
            }

            var person = _personRepository.GetByName(slug);
            if (person == null)
            {
                return NotFound(model);
            }

            var vm = new PersonViewModel(model.Content) { Person = person };

            return base.Index(vm);
        }
        
        private ActionResult NotFound(RenderModel model)
        {
            throw new NotImplementedException("The person is not found");
            return View(model);
        }
    }
}