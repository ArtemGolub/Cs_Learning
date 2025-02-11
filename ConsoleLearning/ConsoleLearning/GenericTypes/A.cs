namespace ConsoleLearning.GenericTypes;

public class A { }
public class A<T> where T: A { }

public interface I { }
public class B<T> where T: I { }


public class C<T> where T: class { }


public class E<T> where T: class? { }


public class D<T> where T: struct { }


public class R<T> where T: unmanaged { }


public class S<T> where T: new() { }


public class Z<T> where T: notnull { }