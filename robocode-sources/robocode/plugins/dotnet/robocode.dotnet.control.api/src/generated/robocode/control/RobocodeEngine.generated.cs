/**
 * Copyright (c) 2001-2020 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * https://robocode.sourceforge.io/license/epl-v10.html
 */
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.8669
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace robocode.control {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaClassAttribute()]
    public partial class RobocodeEngine : global::java.lang.Object {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_close0;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getVersion1;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_addBattleListener2;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_removeBattleListener3;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setVisible4;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getLocalRepository5;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getLocalRepository6;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_runBattle7;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_runBattle8;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_runBattle9;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_waitTillBattleOver10;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_abortCurrentBattle11;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getCurrentWorkingDir12;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_getRobotsDir13;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_printRunningThreads14;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setLogMessagesEnabled15;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n_setLogErrorsEnabled16;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorRobocodeEngine17;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorRobocodeEngine18;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorRobocodeEngine19;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorRobocodeEngine20;
        
        internal static global::net.sf.jni4net.jni.MethodId j4n__ctorRobocodeEngine21;
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/File;)V")]
        public RobocodeEngine(global::java.io.File par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::robocode.control.RobocodeEngine.staticClass, global::robocode.control.RobocodeEngine.j4n__ctorRobocodeEngine17, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/io/File;Lrobocode/control/RobocodeListener;)V")]
        public RobocodeEngine(global::java.io.File par0, global::java.lang.Object par1) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.NewObject(global::robocode.control.RobocodeEngine.staticClass, global::robocode.control.RobocodeEngine.j4n__ctorRobocodeEngine18, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/RobocodeListener;)V")]
        public RobocodeEngine(global::java.lang.Object par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::robocode.control.RobocodeEngine.staticClass, global::robocode.control.RobocodeEngine.j4n__ctorRobocodeEngine19, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::java.lang.Object>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/IBattleListener;)V")]
        public RobocodeEngine(global::robocode.control.events.IBattleListener par0) : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.NewObject(global::robocode.control.RobocodeEngine.staticClass, global::robocode.control.RobocodeEngine.j4n__ctorRobocodeEngine20, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::robocode.control.events.IBattleListener>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public RobocodeEngine() : 
                base(((global::net.sf.jni4net.jni.JNIEnv)(null))) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.NewObject(global::robocode.control.RobocodeEngine.staticClass, global::robocode.control.RobocodeEngine.j4n__ctorRobocodeEngine21, this);
            }
        }
        
        protected RobocodeEngine(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        public static global::java.lang.Class _class {
            get {
                return global::robocode.control.RobocodeEngine.staticClass;
            }
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::robocode.control.RobocodeEngine.staticClass = @__class;
            global::robocode.control.RobocodeEngine.j4n_close0 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "close", "()V");
            global::robocode.control.RobocodeEngine.j4n_getVersion1 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "getVersion", "()Ljava/lang/String;");
            global::robocode.control.RobocodeEngine.j4n_addBattleListener2 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "addBattleListener", "(Lrobocode/control/events/IBattleListener;)V");
            global::robocode.control.RobocodeEngine.j4n_removeBattleListener3 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "removeBattleListener", "(Lrobocode/control/events/IBattleListener;)V");
            global::robocode.control.RobocodeEngine.j4n_setVisible4 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "setVisible", "(Z)V");
            global::robocode.control.RobocodeEngine.j4n_getLocalRepository5 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "getLocalRepository", "()[Lrobocode/control/RobotSpecification;");
            global::robocode.control.RobocodeEngine.j4n_getLocalRepository6 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "getLocalRepository", "(Ljava/lang/String;)[Lrobocode/control/RobotSpecification;");
            global::robocode.control.RobocodeEngine.j4n_runBattle7 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "runBattle", "(Lrobocode/control/BattleSpecification;Z)V");
            global::robocode.control.RobocodeEngine.j4n_runBattle8 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "runBattle", "(Lrobocode/control/BattleSpecification;Ljava/lang/String;Z)V");
            global::robocode.control.RobocodeEngine.j4n_runBattle9 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "runBattle", "(Lrobocode/control/BattleSpecification;)V");
            global::robocode.control.RobocodeEngine.j4n_waitTillBattleOver10 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "waitTillBattleOver", "()V");
            global::robocode.control.RobocodeEngine.j4n_abortCurrentBattle11 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "abortCurrentBattle", "()V");
            global::robocode.control.RobocodeEngine.j4n_getCurrentWorkingDir12 = @__env.GetStaticMethodID(global::robocode.control.RobocodeEngine.staticClass, "getCurrentWorkingDir", "()Ljava/io/File;");
            global::robocode.control.RobocodeEngine.j4n_getRobotsDir13 = @__env.GetStaticMethodID(global::robocode.control.RobocodeEngine.staticClass, "getRobotsDir", "()Ljava/io/File;");
            global::robocode.control.RobocodeEngine.j4n_printRunningThreads14 = @__env.GetStaticMethodID(global::robocode.control.RobocodeEngine.staticClass, "printRunningThreads", "()V");
            global::robocode.control.RobocodeEngine.j4n_setLogMessagesEnabled15 = @__env.GetStaticMethodID(global::robocode.control.RobocodeEngine.staticClass, "setLogMessagesEnabled", "(Z)V");
            global::robocode.control.RobocodeEngine.j4n_setLogErrorsEnabled16 = @__env.GetStaticMethodID(global::robocode.control.RobocodeEngine.staticClass, "setLogErrorsEnabled", "(Z)V");
            global::robocode.control.RobocodeEngine.j4n__ctorRobocodeEngine17 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "<init>", "(Ljava/io/File;)V");
            global::robocode.control.RobocodeEngine.j4n__ctorRobocodeEngine18 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "<init>", "(Ljava/io/File;Lrobocode/control/RobocodeListener;)V");
            global::robocode.control.RobocodeEngine.j4n__ctorRobocodeEngine19 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "<init>", "(Lrobocode/control/RobocodeListener;)V");
            global::robocode.control.RobocodeEngine.j4n__ctorRobocodeEngine20 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "<init>", "(Lrobocode/control/events/IBattleListener;)V");
            global::robocode.control.RobocodeEngine.j4n__ctorRobocodeEngine21 = @__env.GetMethodID(global::robocode.control.RobocodeEngine.staticClass, "<init>", "()V");
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void close() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::robocode.control.RobocodeEngine.j4n_close0);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/lang/String;")]
        public virtual global::java.lang.String getVersion() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2CpString(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobocodeEngine.j4n_getVersion1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/IBattleListener;)V")]
        public virtual void addBattleListener(global::robocode.control.events.IBattleListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.RobocodeEngine.j4n_addBattleListener2, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::robocode.control.events.IBattleListener>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/events/IBattleListener;)V")]
        public virtual void removeBattleListener(global::robocode.control.events.IBattleListener par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.RobocodeEngine.j4n_removeBattleListener3, global::net.sf.jni4net.utils.Convertor.ParFullC2J<global::robocode.control.events.IBattleListener>(@__env, par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)V")]
        public virtual void setVisible(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.RobocodeEngine.j4n_setVisible4, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()[Lrobocode/control/RobotSpecification;")]
        public virtual robocode.control.RobotSpecification[] getLocalRepository() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<robocode.control.RobotSpecification[], global::robocode.control.RobotSpecification>(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobocodeEngine.j4n_getLocalRepository5));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/lang/String;)[Lrobocode/control/RobotSpecification;")]
        public virtual robocode.control.RobotSpecification[] getLocalRepository(global::java.lang.String par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            return global::net.sf.jni4net.utils.Convertor.ArrayStrongJ2Cp<robocode.control.RobotSpecification[], global::robocode.control.RobotSpecification>(@__env, @__env.CallObjectMethodPtr(this, global::robocode.control.RobocodeEngine.j4n_getLocalRepository6, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/BattleSpecification;Z)V")]
        public virtual void runBattle(global::robocode.control.BattleSpecification par0, bool par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::robocode.control.RobocodeEngine.j4n_runBattle7, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par1));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/BattleSpecification;Ljava/lang/String;Z)V")]
        public virtual void runBattle(global::robocode.control.BattleSpecification par0, global::java.lang.String par1, bool par2) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 16)){
            @__env.CallVoidMethod(this, global::robocode.control.RobocodeEngine.j4n_runBattle8, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par2));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lrobocode/control/BattleSpecification;)V")]
        public virtual void runBattle(global::robocode.control.BattleSpecification par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallVoidMethod(this, global::robocode.control.RobocodeEngine.j4n_runBattle9, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void waitTillBattleOver() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::robocode.control.RobocodeEngine.j4n_waitTillBattleOver10);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public virtual void abortCurrentBattle() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::robocode.control.RobocodeEngine.j4n_abortCurrentBattle11);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/File;")]
        public static global::java.io.File getCurrentWorkingDir() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(global::robocode.control.RobocodeEngine.staticClass, global::robocode.control.RobocodeEngine.j4n_getCurrentWorkingDir12));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Ljava/io/File;")]
        public static global::java.io.File getRobotsDir() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.io.File>(@__env, @__env.CallStaticObjectMethodPtr(global::robocode.control.RobocodeEngine.staticClass, global::robocode.control.RobocodeEngine.j4n_getRobotsDir13));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        public static void printRunningThreads() {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallStaticVoidMethod(global::robocode.control.RobocodeEngine.staticClass, global::robocode.control.RobocodeEngine.j4n_printRunningThreads14);
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)V")]
        public static void setLogMessagesEnabled(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallStaticVoidMethod(global::robocode.control.RobocodeEngine.staticClass, global::robocode.control.RobocodeEngine.j4n_setLogMessagesEnabled15, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)V")]
        public static void setLogErrorsEnabled(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 12)){
            @__env.CallStaticVoidMethod(global::robocode.control.RobocodeEngine.staticClass, global::robocode.control.RobocodeEngine.j4n_setLogErrorsEnabled16, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
            }
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::robocode.control.RobocodeEngine(@__env);
            }
        }
    }
    #endregion
}
