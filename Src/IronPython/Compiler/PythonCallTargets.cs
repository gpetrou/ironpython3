/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the  Apache License, Version 2.0, please send an email to 
 * dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System;
using System.Collections;
using Microsoft.Scripting.Utils;
using IronPython.Runtime;
using IronPython.Runtime.Operations;

namespace IronPython.Compiler {
    public delegate object CallTarget0();

    internal static class PythonCallTargets {
        public static object OriginalCallTargetN(PythonFunction function, params object[] args) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object[], object>)function.__code__.Target)(function, args);
        }

        #region Generated Python Lazy Call Targets

        // *** BEGIN GENERATED CODE ***
        // generated by function: gen_lazy_call_targets from: generate_calls.py

        public static object OriginalCallTarget0(PythonFunction function) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object>)function.__code__.Target)(function);
        }

        public static object OriginalCallTarget1(PythonFunction function, object arg0) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object>)function.__code__.Target)(function, arg0);
        }

        public static object OriginalCallTarget2(PythonFunction function, object arg0, object arg1) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object>)function.__code__.Target)(function, arg0, arg1);
        }

        public static object OriginalCallTarget3(PythonFunction function, object arg0, object arg1, object arg2) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2);
        }

        public static object OriginalCallTarget4(PythonFunction function, object arg0, object arg1, object arg2, object arg3) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2, arg3);
        }

        public static object OriginalCallTarget5(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2, arg3, arg4);
        }

        public static object OriginalCallTarget6(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5);
        }

        public static object OriginalCallTarget7(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static object OriginalCallTarget8(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object, object, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static object OriginalCallTarget9(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object, object, object, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static object OriginalCallTarget10(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static object OriginalCallTarget11(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static object OriginalCallTarget12(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }

        public static object OriginalCallTarget13(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        }

        public static object OriginalCallTarget14(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        }

        public static object OriginalCallTarget15(PythonFunction function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14) {
            function.__code__.LazyCompileFirstTarget(function);
            return ((Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>)function.__code__.Target)(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        }


        // *** END GENERATED CODE ***

        #endregion
        
        public const int MaxArgs = 15;
        internal static Type GetPythonTargetType(bool wrapper, int parameters, out Delegate originalTarget) {
            if (!wrapper) {
                switch (parameters) {
                    #region Generated Python Call Target Switch

                    // *** BEGIN GENERATED CODE ***
                    // generated by function: gen_python_switch from: generate_calls.py

                    case 0: 
                        originalTarget = (Func<PythonFunction, object>)OriginalCallTarget0;
                        return typeof(Func<PythonFunction, object>);
                    case 1: 
                        originalTarget = (Func<PythonFunction, object, object>)OriginalCallTarget1;
                        return typeof(Func<PythonFunction, object, object>);
                    case 2: 
                        originalTarget = (Func<PythonFunction, object, object, object>)OriginalCallTarget2;
                        return typeof(Func<PythonFunction, object, object, object>);
                    case 3: 
                        originalTarget = (Func<PythonFunction, object, object, object, object>)OriginalCallTarget3;
                        return typeof(Func<PythonFunction, object, object, object, object>);
                    case 4: 
                        originalTarget = (Func<PythonFunction, object, object, object, object, object>)OriginalCallTarget4;
                        return typeof(Func<PythonFunction, object, object, object, object, object>);
                    case 5: 
                        originalTarget = (Func<PythonFunction, object, object, object, object, object, object>)OriginalCallTarget5;
                        return typeof(Func<PythonFunction, object, object, object, object, object, object>);
                    case 6: 
                        originalTarget = (Func<PythonFunction, object, object, object, object, object, object, object>)OriginalCallTarget6;
                        return typeof(Func<PythonFunction, object, object, object, object, object, object, object>);
                    case 7: 
                        originalTarget = (Func<PythonFunction, object, object, object, object, object, object, object, object>)OriginalCallTarget7;
                        return typeof(Func<PythonFunction, object, object, object, object, object, object, object, object>);
                    case 8: 
                        originalTarget = (Func<PythonFunction, object, object, object, object, object, object, object, object, object>)OriginalCallTarget8;
                        return typeof(Func<PythonFunction, object, object, object, object, object, object, object, object, object>);
                    case 9: 
                        originalTarget = (Func<PythonFunction, object, object, object, object, object, object, object, object, object, object>)OriginalCallTarget9;
                        return typeof(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object>);
                    case 10: 
                        originalTarget = (Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object>)OriginalCallTarget10;
                        return typeof(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object>);
                    case 11: 
                        originalTarget = (Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object>)OriginalCallTarget11;
                        return typeof(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object>);
                    case 12: 
                        originalTarget = (Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object>)OriginalCallTarget12;
                        return typeof(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object>);
                    case 13: 
                        originalTarget = (Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object>)OriginalCallTarget13;
                        return typeof(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object>);
                    case 14: 
                        originalTarget = (Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>)OriginalCallTarget14;
                        return typeof(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>);
                    case 15: 
                        originalTarget = (Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>)OriginalCallTarget15;
                        return typeof(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>);

                    // *** END GENERATED CODE ***

                    #endregion
                }
            }

            originalTarget = (Func<PythonFunction, object[], object>)OriginalCallTargetN;
            return typeof(Func<PythonFunction, object[], object>);
        }
    }

    internal class PythonFunctionRecursionCheckN {
        private readonly Func<PythonFunction, object[], object> _target;

        public PythonFunctionRecursionCheckN(Func<PythonFunction, object[], object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object[] args) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, args);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    #region Generated Python Recursion Enforcement

    // *** BEGIN GENERATED CODE ***
    // generated by function: gen_recursion_checks from: generate_calls.py

    internal class PythonFunctionRecursionCheck0 {
        private readonly Func<PythonFunction, object> _target;

        public PythonFunctionRecursionCheck0(Func<PythonFunction, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck1 {
        private readonly Func<PythonFunction, object, object> _target;

        public PythonFunctionRecursionCheck1(Func<PythonFunction, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck2 {
        private readonly Func<PythonFunction, object, object, object> _target;

        public PythonFunctionRecursionCheck2(Func<PythonFunction, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck3 {
        private readonly Func<PythonFunction, object, object, object, object> _target;

        public PythonFunctionRecursionCheck3(Func<PythonFunction, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck4 {
        private readonly Func<PythonFunction, object, object, object, object, object> _target;

        public PythonFunctionRecursionCheck4(Func<PythonFunction, object, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2, object arg3) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2, arg3);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck5 {
        private readonly Func<PythonFunction, object, object, object, object, object, object> _target;

        public PythonFunctionRecursionCheck5(Func<PythonFunction, object, object, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2, object arg3, object arg4) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2, arg3, arg4);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck6 {
        private readonly Func<PythonFunction, object, object, object, object, object, object, object> _target;

        public PythonFunctionRecursionCheck6(Func<PythonFunction, object, object, object, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2, arg3, arg4, arg5);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck7 {
        private readonly Func<PythonFunction, object, object, object, object, object, object, object, object> _target;

        public PythonFunctionRecursionCheck7(Func<PythonFunction, object, object, object, object, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck8 {
        private readonly Func<PythonFunction, object, object, object, object, object, object, object, object, object> _target;

        public PythonFunctionRecursionCheck8(Func<PythonFunction, object, object, object, object, object, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck9 {
        private readonly Func<PythonFunction, object, object, object, object, object, object, object, object, object, object> _target;

        public PythonFunctionRecursionCheck9(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck10 {
        private readonly Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object> _target;

        public PythonFunctionRecursionCheck10(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck11 {
        private readonly Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object> _target;

        public PythonFunctionRecursionCheck11(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck12 {
        private readonly Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object> _target;

        public PythonFunctionRecursionCheck12(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck13 {
        private readonly Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object> _target;

        public PythonFunctionRecursionCheck13(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck14 {
        private readonly Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> _target;

        public PythonFunctionRecursionCheck14(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13) {
            PythonOps.FunctionPushFrame((PythonContext)function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }

    internal class PythonFunctionRecursionCheck15 {
        private readonly Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> _target;

        public PythonFunctionRecursionCheck15(Func<PythonFunction, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> target) {
            _target = target;
        }

        public object CallTarget(PythonFunction/*!*/ function, object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9, object arg10, object arg11, object arg12, object arg13, object arg14) {
            PythonOps.FunctionPushFrame(function.Context.LanguageContext);
            try {
                return _target(function, arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            } finally {
                PythonOps.FunctionPopFrame();
            }
        }
    }


    // *** END GENERATED CODE ***

    #endregion

}
