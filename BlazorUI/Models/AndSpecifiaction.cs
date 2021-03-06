﻿using BlazorUI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorUI.Models
{
    public class AndSpecifiaction<T> : ISpecification<T>
    {
        private ISpecification<T>[] _specifications;

        public AndSpecifiaction(ISpecification<T>[] specifications)
        {
            _specifications = specifications ?? throw new ArgumentNullException(paramName: nameof(specifications));
        }

        public bool IsSatisfied(T t)
        {
            foreach (var specification in _specifications)
            {
                if (specification.IsSatisfied(t) == false)
                {
                    return false;
                }
            }
            return true;
        }

        //private ISpecification<T> _first, _second;

        //public AndSpecifiaction(ISpecification<T> first, ISpecification<T> second)
        //{
        //    _first = first ?? throw new ArgumentNullException(paramName: nameof(first));
        //    _second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        //}

        //public bool IsSatisfied(T t)
        //{
        //    return _first.IsSatisfied(t) && _second.IsSatisfied(t);
        //}
    }
}
