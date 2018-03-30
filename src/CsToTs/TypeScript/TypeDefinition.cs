﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CsToTs.TypeScript {
    
    public class TypeDefinition {

        public TypeDefinition(Type clrType, string declaration, CtorDefinition ctor = null) {
            ClrType = clrType;
            Declaration = declaration;
            Ctor = ctor;
            Members = new List<MemberDefinition>();
            Methods = new List<MethodDefinition>();
        }
        
        public Type ClrType { get; }
        public string Declaration { get; }
        public CtorDefinition Ctor { get; }
        public List<MemberDefinition> Members { get; }
        public List<MethodDefinition> Methods { get; }
    }
}