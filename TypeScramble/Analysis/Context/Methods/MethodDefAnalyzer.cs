﻿using dnlib.DotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScramble.Analysis.Context.Methods {
    class MethodDefAnalyzer : MethodContextAnalyzer<MethodDef> {
        public override void Process(ITypeService service, MethodDef m, MethodDef o) {

            var chainCall = service.GetScannedMethod(o);
            if(chainCall != null) {
                foreach(var t in chainCall.AssociatedTypes) {
                    service.AddAssociatedType(o, t);
                }
            }

        }
    }
}
