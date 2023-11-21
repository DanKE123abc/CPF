﻿using System;
using System.Linq.Expressions;

namespace CPF.Json.Serializer
{
    [ExpressionBuildType(SerializerBuildTypeEnum.Lazy)]
    internal class LazyBuild : ExpressionJsonFormatter
    {
        internal static Expression Build(Type type, ParameterExpression instanceArg)
        {
            Expression orginal = ExpressionMembers.GetMethodCall(type.GetGenericArguments()[0], Expression.MakeMemberAccess(instanceArg, type.GetProperty("Value")));

            return Expression.IfThenElse(
                         Expression.Equal(instanceArg, Expression.Constant(null,type)),
                         ExpressionMembers.Append("null")
                         ,
                         //para.value
                         orginal
                         );
        }
    }
}