﻿using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Website.Sample.PublishedContentModels;

namespace Website.Sample.ExternalData
{
    public class PeopleController : RenderMvcController
    {
        private readonly PersonRepository _personRepository;

        public PeopleController()
        {
            _personRepository = new PersonRepository();
        }

        // GET: Person
        public override ActionResult Index(RenderModel model)
        {
            if (model?.Content == null) { return HttpNotFound(); }

            var persons = _personRepository.GetAll();
            if (persons == null) { return HttpNotFound(); }

            var vm = new PersonListViewModel(model.Content) { Persons = persons };

            return base.Index(vm);
        }
    }
}