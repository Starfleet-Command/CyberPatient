#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E (void);
// 0x00000002 System.Exception System.Linq.Error::ArgumentOutOfRange(System.String)
extern void Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2 (void);
// 0x00000003 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8 (void);
// 0x00000004 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mB89E91246572F009281D79730950808F17C3F353 (void);
// 0x00000005 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000006 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
// 0x00000007 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000008 System.Func`2<TSource,TResult> System.Linq.Enumerable::CombineSelectors(System.Func`2<TSource,TMiddle>,System.Func`2<TMiddle,TResult>)
// 0x00000009 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectMany(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectManyIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000B System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::OrderBy(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000C System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Distinct(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000D System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::DistinctIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000000E TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000F System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000010 TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000011 TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000012 TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000013 TSource System.Linq.Enumerable::ElementAt(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x00000014 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000015 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000016 System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000017 System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000018 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource)
// 0x00000019 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000001A System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x0000001B TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x0000001C System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x0000001D System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x0000001E System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x0000001F System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x00000020 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/Iterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000021 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000022 System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x00000023 System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000024 System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x00000025 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000026 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x00000027 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x00000028 System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x00000029 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereEnumerableIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000002A System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000002B System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x0000002C System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x0000002D System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x0000002E System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereArrayIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000002F System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000030 System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000031 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x00000032 System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x00000033 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereListIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000034 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000035 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000036 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()
// 0x00000037 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Dispose()
// 0x00000038 System.Boolean System.Linq.Enumerable/WhereSelectEnumerableIterator`2::MoveNext()
// 0x00000039 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000003A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x0000003B System.Void System.Linq.Enumerable/WhereSelectArrayIterator`2::.ctor(TSource[],System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000003C System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()
// 0x0000003D System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()
// 0x0000003E System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectArrayIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000003F System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000040 System.Void System.Linq.Enumerable/WhereSelectListIterator`2::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000041 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Clone()
// 0x00000042 System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2::MoveNext()
// 0x00000043 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectListIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000044 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000045 System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x00000046 System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x00000047 System.Void System.Linq.Enumerable/<>c__DisplayClass7_0`3::.ctor()
// 0x00000048 TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)
// 0x00000049 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::.ctor(System.Int32)
// 0x0000004A System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.IDisposable.Dispose()
// 0x0000004B System.Boolean System.Linq.Enumerable/<SelectManyIterator>d__17`2::MoveNext()
// 0x0000004C System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally1()
// 0x0000004D System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally2()
// 0x0000004E TResult System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerator<TResult>.get_Current()
// 0x0000004F System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.Reset()
// 0x00000050 System.Object System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.get_Current()
// 0x00000051 System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
// 0x00000052 System.Collections.IEnumerator System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerable.GetEnumerator()
// 0x00000053 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::.ctor(System.Int32)
// 0x00000054 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.IDisposable.Dispose()
// 0x00000055 System.Boolean System.Linq.Enumerable/<DistinctIterator>d__68`1::MoveNext()
// 0x00000056 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::<>m__Finally1()
// 0x00000057 TSource System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x00000058 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.Reset()
// 0x00000059 System.Object System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.get_Current()
// 0x0000005A System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x0000005B System.Collections.IEnumerator System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000005C System.Void System.Linq.Set`1::.ctor(System.Collections.Generic.IEqualityComparer`1<TElement>)
// 0x0000005D System.Boolean System.Linq.Set`1::Add(TElement)
// 0x0000005E System.Boolean System.Linq.Set`1::Find(TElement,System.Boolean)
// 0x0000005F System.Void System.Linq.Set`1::Resize()
// 0x00000060 System.Int32 System.Linq.Set`1::InternalGetHashCode(TElement)
// 0x00000061 System.Collections.Generic.IEnumerator`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerator()
// 0x00000062 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000063 System.Collections.IEnumerator System.Linq.OrderedEnumerable`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000064 System.Void System.Linq.OrderedEnumerable`1::.ctor()
// 0x00000065 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::.ctor(System.Int32)
// 0x00000066 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.IDisposable.Dispose()
// 0x00000067 System.Boolean System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::MoveNext()
// 0x00000068 TElement System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.Generic.IEnumerator<TElement>.get_Current()
// 0x00000069 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.Reset()
// 0x0000006A System.Object System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.get_Current()
// 0x0000006B System.Void System.Linq.OrderedEnumerable`2::.ctor(System.Collections.Generic.IEnumerable`1<TElement>,System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x0000006C System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`2::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x0000006D System.Void System.Linq.EnumerableSorter`1::ComputeKeys(TElement[],System.Int32)
// 0x0000006E System.Int32 System.Linq.EnumerableSorter`1::CompareKeys(System.Int32,System.Int32)
// 0x0000006F System.Int32[] System.Linq.EnumerableSorter`1::Sort(TElement[],System.Int32)
// 0x00000070 System.Void System.Linq.EnumerableSorter`1::QuickSort(System.Int32[],System.Int32,System.Int32)
// 0x00000071 System.Void System.Linq.EnumerableSorter`1::.ctor()
// 0x00000072 System.Void System.Linq.EnumerableSorter`2::.ctor(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean,System.Linq.EnumerableSorter`1<TElement>)
// 0x00000073 System.Void System.Linq.EnumerableSorter`2::ComputeKeys(TElement[],System.Int32)
// 0x00000074 System.Int32 System.Linq.EnumerableSorter`2::CompareKeys(System.Int32,System.Int32)
// 0x00000075 System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x00000076 TElement[] System.Linq.Buffer`1::ToArray()
// 0x00000077 System.Void System.Collections.Generic.HashSet`1::.ctor()
// 0x00000078 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
// 0x00000079 System.Void System.Collections.Generic.HashSet`1::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x0000007A System.Void System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.Add(T)
// 0x0000007B System.Void System.Collections.Generic.HashSet`1::Clear()
// 0x0000007C System.Boolean System.Collections.Generic.HashSet`1::Contains(T)
// 0x0000007D System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32)
// 0x0000007E System.Boolean System.Collections.Generic.HashSet`1::Remove(T)
// 0x0000007F System.Int32 System.Collections.Generic.HashSet`1::get_Count()
// 0x00000080 System.Boolean System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.get_IsReadOnly()
// 0x00000081 System.Collections.Generic.HashSet`1/Enumerator<T> System.Collections.Generic.HashSet`1::GetEnumerator()
// 0x00000082 System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.HashSet`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
// 0x00000083 System.Collections.IEnumerator System.Collections.Generic.HashSet`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000084 System.Void System.Collections.Generic.HashSet`1::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000085 System.Void System.Collections.Generic.HashSet`1::OnDeserialization(System.Object)
// 0x00000086 System.Boolean System.Collections.Generic.HashSet`1::Add(T)
// 0x00000087 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[])
// 0x00000088 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32,System.Int32)
// 0x00000089 System.Void System.Collections.Generic.HashSet`1::Initialize(System.Int32)
// 0x0000008A System.Void System.Collections.Generic.HashSet`1::IncreaseCapacity()
// 0x0000008B System.Void System.Collections.Generic.HashSet`1::SetCapacity(System.Int32)
// 0x0000008C System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)
// 0x0000008D System.Int32 System.Collections.Generic.HashSet`1::InternalGetHashCode(T)
// 0x0000008E System.Void System.Collections.Generic.HashSet`1/Enumerator::.ctor(System.Collections.Generic.HashSet`1<T>)
// 0x0000008F System.Void System.Collections.Generic.HashSet`1/Enumerator::Dispose()
// 0x00000090 System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()
// 0x00000091 T System.Collections.Generic.HashSet`1/Enumerator::get_Current()
// 0x00000092 System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()
// 0x00000093 System.Void System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.Reset()
static Il2CppMethodPointer s_methodPointers[147] = 
{
	Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E,
	Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2,
	Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8,
	Error_NoElements_mB89E91246572F009281D79730950808F17C3F353,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[147] = 
{
	3431,
	3431,
	3571,
	3571,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[47] = 
{
	{ 0x02000004, { 72, 4 } },
	{ 0x02000005, { 76, 9 } },
	{ 0x02000006, { 87, 7 } },
	{ 0x02000007, { 96, 10 } },
	{ 0x02000008, { 108, 11 } },
	{ 0x02000009, { 122, 9 } },
	{ 0x0200000A, { 134, 12 } },
	{ 0x0200000B, { 149, 1 } },
	{ 0x0200000C, { 150, 2 } },
	{ 0x0200000D, { 152, 12 } },
	{ 0x0200000E, { 164, 11 } },
	{ 0x02000010, { 175, 8 } },
	{ 0x02000012, { 183, 3 } },
	{ 0x02000013, { 186, 5 } },
	{ 0x02000014, { 191, 7 } },
	{ 0x02000015, { 198, 3 } },
	{ 0x02000016, { 201, 7 } },
	{ 0x02000017, { 208, 4 } },
	{ 0x02000018, { 212, 21 } },
	{ 0x0200001A, { 233, 2 } },
	{ 0x06000005, { 0, 10 } },
	{ 0x06000006, { 10, 10 } },
	{ 0x06000007, { 20, 5 } },
	{ 0x06000008, { 25, 5 } },
	{ 0x06000009, { 30, 1 } },
	{ 0x0600000A, { 31, 2 } },
	{ 0x0600000B, { 33, 2 } },
	{ 0x0600000C, { 35, 1 } },
	{ 0x0600000D, { 36, 2 } },
	{ 0x0600000E, { 38, 3 } },
	{ 0x0600000F, { 41, 2 } },
	{ 0x06000010, { 43, 4 } },
	{ 0x06000011, { 47, 3 } },
	{ 0x06000012, { 50, 3 } },
	{ 0x06000013, { 53, 3 } },
	{ 0x06000014, { 56, 1 } },
	{ 0x06000015, { 57, 3 } },
	{ 0x06000016, { 60, 2 } },
	{ 0x06000017, { 62, 3 } },
	{ 0x06000018, { 65, 2 } },
	{ 0x06000019, { 67, 5 } },
	{ 0x06000029, { 85, 2 } },
	{ 0x0600002E, { 94, 2 } },
	{ 0x06000033, { 106, 2 } },
	{ 0x06000039, { 119, 3 } },
	{ 0x0600003E, { 131, 3 } },
	{ 0x06000043, { 146, 3 } },
};
static const Il2CppRGCTXDefinition s_rgctxValues[235] = 
{
	{ (Il2CppRGCTXDataType)2, 1740 },
	{ (Il2CppRGCTXDataType)3, 5846 },
	{ (Il2CppRGCTXDataType)2, 2943 },
	{ (Il2CppRGCTXDataType)2, 2508 },
	{ (Il2CppRGCTXDataType)3, 12278 },
	{ (Il2CppRGCTXDataType)2, 1837 },
	{ (Il2CppRGCTXDataType)2, 2515 },
	{ (Il2CppRGCTXDataType)3, 12317 },
	{ (Il2CppRGCTXDataType)2, 2510 },
	{ (Il2CppRGCTXDataType)3, 12285 },
	{ (Il2CppRGCTXDataType)2, 1741 },
	{ (Il2CppRGCTXDataType)3, 5847 },
	{ (Il2CppRGCTXDataType)2, 2958 },
	{ (Il2CppRGCTXDataType)2, 2517 },
	{ (Il2CppRGCTXDataType)3, 12324 },
	{ (Il2CppRGCTXDataType)2, 1854 },
	{ (Il2CppRGCTXDataType)2, 2525 },
	{ (Il2CppRGCTXDataType)3, 12381 },
	{ (Il2CppRGCTXDataType)2, 2521 },
	{ (Il2CppRGCTXDataType)3, 12350 },
	{ (Il2CppRGCTXDataType)2, 640 },
	{ (Il2CppRGCTXDataType)3, 51 },
	{ (Il2CppRGCTXDataType)3, 52 },
	{ (Il2CppRGCTXDataType)2, 1114 },
	{ (Il2CppRGCTXDataType)3, 4478 },
	{ (Il2CppRGCTXDataType)2, 641 },
	{ (Il2CppRGCTXDataType)3, 63 },
	{ (Il2CppRGCTXDataType)3, 64 },
	{ (Il2CppRGCTXDataType)2, 1123 },
	{ (Il2CppRGCTXDataType)3, 4482 },
	{ (Il2CppRGCTXDataType)3, 14214 },
	{ (Il2CppRGCTXDataType)2, 646 },
	{ (Il2CppRGCTXDataType)3, 97 },
	{ (Il2CppRGCTXDataType)2, 2242 },
	{ (Il2CppRGCTXDataType)3, 9852 },
	{ (Il2CppRGCTXDataType)3, 14192 },
	{ (Il2CppRGCTXDataType)2, 642 },
	{ (Il2CppRGCTXDataType)3, 69 },
	{ (Il2CppRGCTXDataType)2, 744 },
	{ (Il2CppRGCTXDataType)3, 966 },
	{ (Il2CppRGCTXDataType)3, 967 },
	{ (Il2CppRGCTXDataType)2, 1838 },
	{ (Il2CppRGCTXDataType)3, 6236 },
	{ (Il2CppRGCTXDataType)2, 1671 },
	{ (Il2CppRGCTXDataType)2, 1242 },
	{ (Il2CppRGCTXDataType)2, 1341 },
	{ (Il2CppRGCTXDataType)2, 1435 },
	{ (Il2CppRGCTXDataType)2, 1342 },
	{ (Il2CppRGCTXDataType)2, 1436 },
	{ (Il2CppRGCTXDataType)3, 4480 },
	{ (Il2CppRGCTXDataType)2, 1343 },
	{ (Il2CppRGCTXDataType)2, 1437 },
	{ (Il2CppRGCTXDataType)3, 4481 },
	{ (Il2CppRGCTXDataType)2, 1670 },
	{ (Il2CppRGCTXDataType)2, 1340 },
	{ (Il2CppRGCTXDataType)2, 1434 },
	{ (Il2CppRGCTXDataType)2, 1330 },
	{ (Il2CppRGCTXDataType)2, 1331 },
	{ (Il2CppRGCTXDataType)2, 1431 },
	{ (Il2CppRGCTXDataType)3, 4477 },
	{ (Il2CppRGCTXDataType)2, 1241 },
	{ (Il2CppRGCTXDataType)2, 1338 },
	{ (Il2CppRGCTXDataType)2, 1339 },
	{ (Il2CppRGCTXDataType)2, 1433 },
	{ (Il2CppRGCTXDataType)3, 4479 },
	{ (Il2CppRGCTXDataType)2, 1240 },
	{ (Il2CppRGCTXDataType)3, 14179 },
	{ (Il2CppRGCTXDataType)3, 3863 },
	{ (Il2CppRGCTXDataType)2, 1002 },
	{ (Il2CppRGCTXDataType)2, 1333 },
	{ (Il2CppRGCTXDataType)2, 1432 },
	{ (Il2CppRGCTXDataType)2, 1510 },
	{ (Il2CppRGCTXDataType)3, 5848 },
	{ (Il2CppRGCTXDataType)3, 5850 },
	{ (Il2CppRGCTXDataType)2, 450 },
	{ (Il2CppRGCTXDataType)3, 5849 },
	{ (Il2CppRGCTXDataType)3, 5858 },
	{ (Il2CppRGCTXDataType)2, 1744 },
	{ (Il2CppRGCTXDataType)2, 2511 },
	{ (Il2CppRGCTXDataType)3, 12286 },
	{ (Il2CppRGCTXDataType)3, 5859 },
	{ (Il2CppRGCTXDataType)2, 1385 },
	{ (Il2CppRGCTXDataType)2, 1461 },
	{ (Il2CppRGCTXDataType)3, 4489 },
	{ (Il2CppRGCTXDataType)3, 14165 },
	{ (Il2CppRGCTXDataType)2, 2522 },
	{ (Il2CppRGCTXDataType)3, 12351 },
	{ (Il2CppRGCTXDataType)3, 5851 },
	{ (Il2CppRGCTXDataType)2, 1743 },
	{ (Il2CppRGCTXDataType)2, 2509 },
	{ (Il2CppRGCTXDataType)3, 12279 },
	{ (Il2CppRGCTXDataType)3, 4488 },
	{ (Il2CppRGCTXDataType)3, 5852 },
	{ (Il2CppRGCTXDataType)3, 14164 },
	{ (Il2CppRGCTXDataType)2, 2518 },
	{ (Il2CppRGCTXDataType)3, 12325 },
	{ (Il2CppRGCTXDataType)3, 5865 },
	{ (Il2CppRGCTXDataType)2, 1745 },
	{ (Il2CppRGCTXDataType)2, 2516 },
	{ (Il2CppRGCTXDataType)3, 12318 },
	{ (Il2CppRGCTXDataType)3, 6284 },
	{ (Il2CppRGCTXDataType)3, 3113 },
	{ (Il2CppRGCTXDataType)3, 4490 },
	{ (Il2CppRGCTXDataType)3, 3112 },
	{ (Il2CppRGCTXDataType)3, 5866 },
	{ (Il2CppRGCTXDataType)3, 14166 },
	{ (Il2CppRGCTXDataType)2, 2526 },
	{ (Il2CppRGCTXDataType)3, 12382 },
	{ (Il2CppRGCTXDataType)3, 5879 },
	{ (Il2CppRGCTXDataType)2, 1747 },
	{ (Il2CppRGCTXDataType)2, 2524 },
	{ (Il2CppRGCTXDataType)3, 12353 },
	{ (Il2CppRGCTXDataType)3, 5880 },
	{ (Il2CppRGCTXDataType)2, 1388 },
	{ (Il2CppRGCTXDataType)2, 1464 },
	{ (Il2CppRGCTXDataType)3, 4494 },
	{ (Il2CppRGCTXDataType)3, 4493 },
	{ (Il2CppRGCTXDataType)2, 2513 },
	{ (Il2CppRGCTXDataType)3, 12288 },
	{ (Il2CppRGCTXDataType)3, 14173 },
	{ (Il2CppRGCTXDataType)2, 2523 },
	{ (Il2CppRGCTXDataType)3, 12352 },
	{ (Il2CppRGCTXDataType)3, 5872 },
	{ (Il2CppRGCTXDataType)2, 1746 },
	{ (Il2CppRGCTXDataType)2, 2520 },
	{ (Il2CppRGCTXDataType)3, 12327 },
	{ (Il2CppRGCTXDataType)3, 4492 },
	{ (Il2CppRGCTXDataType)3, 4491 },
	{ (Il2CppRGCTXDataType)3, 5873 },
	{ (Il2CppRGCTXDataType)2, 2512 },
	{ (Il2CppRGCTXDataType)3, 12287 },
	{ (Il2CppRGCTXDataType)3, 14172 },
	{ (Il2CppRGCTXDataType)2, 2519 },
	{ (Il2CppRGCTXDataType)3, 12326 },
	{ (Il2CppRGCTXDataType)3, 5886 },
	{ (Il2CppRGCTXDataType)2, 1748 },
	{ (Il2CppRGCTXDataType)2, 2528 },
	{ (Il2CppRGCTXDataType)3, 12384 },
	{ (Il2CppRGCTXDataType)3, 6285 },
	{ (Il2CppRGCTXDataType)3, 3115 },
	{ (Il2CppRGCTXDataType)3, 4496 },
	{ (Il2CppRGCTXDataType)3, 4495 },
	{ (Il2CppRGCTXDataType)3, 3114 },
	{ (Il2CppRGCTXDataType)3, 5887 },
	{ (Il2CppRGCTXDataType)2, 2514 },
	{ (Il2CppRGCTXDataType)3, 12289 },
	{ (Il2CppRGCTXDataType)3, 14174 },
	{ (Il2CppRGCTXDataType)2, 2527 },
	{ (Il2CppRGCTXDataType)3, 12383 },
	{ (Il2CppRGCTXDataType)3, 4485 },
	{ (Il2CppRGCTXDataType)3, 4486 },
	{ (Il2CppRGCTXDataType)3, 4497 },
	{ (Il2CppRGCTXDataType)3, 100 },
	{ (Il2CppRGCTXDataType)3, 99 },
	{ (Il2CppRGCTXDataType)2, 1380 },
	{ (Il2CppRGCTXDataType)2, 1457 },
	{ (Il2CppRGCTXDataType)3, 4487 },
	{ (Il2CppRGCTXDataType)2, 1394 },
	{ (Il2CppRGCTXDataType)2, 1475 },
	{ (Il2CppRGCTXDataType)3, 102 },
	{ (Il2CppRGCTXDataType)2, 578 },
	{ (Il2CppRGCTXDataType)2, 647 },
	{ (Il2CppRGCTXDataType)3, 98 },
	{ (Il2CppRGCTXDataType)3, 101 },
	{ (Il2CppRGCTXDataType)3, 71 },
	{ (Il2CppRGCTXDataType)2, 2348 },
	{ (Il2CppRGCTXDataType)3, 11376 },
	{ (Il2CppRGCTXDataType)2, 1377 },
	{ (Il2CppRGCTXDataType)2, 1455 },
	{ (Il2CppRGCTXDataType)3, 11377 },
	{ (Il2CppRGCTXDataType)3, 73 },
	{ (Il2CppRGCTXDataType)2, 447 },
	{ (Il2CppRGCTXDataType)2, 643 },
	{ (Il2CppRGCTXDataType)3, 70 },
	{ (Il2CppRGCTXDataType)3, 72 },
	{ (Il2CppRGCTXDataType)3, 3896 },
	{ (Il2CppRGCTXDataType)2, 1016 },
	{ (Il2CppRGCTXDataType)2, 3042 },
	{ (Il2CppRGCTXDataType)3, 11373 },
	{ (Il2CppRGCTXDataType)3, 11374 },
	{ (Il2CppRGCTXDataType)2, 1524 },
	{ (Il2CppRGCTXDataType)3, 11375 },
	{ (Il2CppRGCTXDataType)2, 387 },
	{ (Il2CppRGCTXDataType)2, 644 },
	{ (Il2CppRGCTXDataType)3, 83 },
	{ (Il2CppRGCTXDataType)3, 9842 },
	{ (Il2CppRGCTXDataType)2, 745 },
	{ (Il2CppRGCTXDataType)3, 968 },
	{ (Il2CppRGCTXDataType)3, 9847 },
	{ (Il2CppRGCTXDataType)3, 3090 },
	{ (Il2CppRGCTXDataType)2, 481 },
	{ (Il2CppRGCTXDataType)3, 9843 },
	{ (Il2CppRGCTXDataType)2, 2239 },
	{ (Il2CppRGCTXDataType)3, 1002 },
	{ (Il2CppRGCTXDataType)2, 759 },
	{ (Il2CppRGCTXDataType)2, 977 },
	{ (Il2CppRGCTXDataType)3, 3096 },
	{ (Il2CppRGCTXDataType)3, 9844 },
	{ (Il2CppRGCTXDataType)3, 3085 },
	{ (Il2CppRGCTXDataType)3, 3086 },
	{ (Il2CppRGCTXDataType)3, 3084 },
	{ (Il2CppRGCTXDataType)3, 3087 },
	{ (Il2CppRGCTXDataType)2, 973 },
	{ (Il2CppRGCTXDataType)2, 3005 },
	{ (Il2CppRGCTXDataType)3, 4484 },
	{ (Il2CppRGCTXDataType)3, 3089 },
	{ (Il2CppRGCTXDataType)2, 1316 },
	{ (Il2CppRGCTXDataType)3, 3088 },
	{ (Il2CppRGCTXDataType)2, 1243 },
	{ (Il2CppRGCTXDataType)2, 2961 },
	{ (Il2CppRGCTXDataType)2, 1356 },
	{ (Il2CppRGCTXDataType)2, 1438 },
	{ (Il2CppRGCTXDataType)3, 3879 },
	{ (Il2CppRGCTXDataType)2, 1010 },
	{ (Il2CppRGCTXDataType)3, 4804 },
	{ (Il2CppRGCTXDataType)3, 4805 },
	{ (Il2CppRGCTXDataType)3, 4810 },
	{ (Il2CppRGCTXDataType)2, 1519 },
	{ (Il2CppRGCTXDataType)3, 4807 },
	{ (Il2CppRGCTXDataType)3, 14614 },
	{ (Il2CppRGCTXDataType)2, 979 },
	{ (Il2CppRGCTXDataType)3, 3105 },
	{ (Il2CppRGCTXDataType)1, 1313 },
	{ (Il2CppRGCTXDataType)2, 2973 },
	{ (Il2CppRGCTXDataType)3, 4806 },
	{ (Il2CppRGCTXDataType)1, 2973 },
	{ (Il2CppRGCTXDataType)1, 1519 },
	{ (Il2CppRGCTXDataType)2, 3040 },
	{ (Il2CppRGCTXDataType)2, 2973 },
	{ (Il2CppRGCTXDataType)3, 4811 },
	{ (Il2CppRGCTXDataType)3, 4809 },
	{ (Il2CppRGCTXDataType)3, 4808 },
	{ (Il2CppRGCTXDataType)2, 324 },
	{ (Il2CppRGCTXDataType)3, 3116 },
	{ (Il2CppRGCTXDataType)2, 460 },
};
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	147,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	47,
	s_rgctxIndices,
	235,
	s_rgctxValues,
	NULL,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
