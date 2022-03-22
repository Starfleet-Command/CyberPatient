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
	3436,
	3436,
	3577,
	3577,
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
	{ (Il2CppRGCTXDataType)2, 1744 },
	{ (Il2CppRGCTXDataType)3, 5865 },
	{ (Il2CppRGCTXDataType)2, 2960 },
	{ (Il2CppRGCTXDataType)2, 2523 },
	{ (Il2CppRGCTXDataType)3, 12318 },
	{ (Il2CppRGCTXDataType)2, 1841 },
	{ (Il2CppRGCTXDataType)2, 2530 },
	{ (Il2CppRGCTXDataType)3, 12357 },
	{ (Il2CppRGCTXDataType)2, 2525 },
	{ (Il2CppRGCTXDataType)3, 12325 },
	{ (Il2CppRGCTXDataType)2, 1745 },
	{ (Il2CppRGCTXDataType)3, 5866 },
	{ (Il2CppRGCTXDataType)2, 2977 },
	{ (Il2CppRGCTXDataType)2, 2532 },
	{ (Il2CppRGCTXDataType)3, 12364 },
	{ (Il2CppRGCTXDataType)2, 1858 },
	{ (Il2CppRGCTXDataType)2, 2540 },
	{ (Il2CppRGCTXDataType)3, 12421 },
	{ (Il2CppRGCTXDataType)2, 2536 },
	{ (Il2CppRGCTXDataType)3, 12390 },
	{ (Il2CppRGCTXDataType)2, 642 },
	{ (Il2CppRGCTXDataType)3, 51 },
	{ (Il2CppRGCTXDataType)3, 52 },
	{ (Il2CppRGCTXDataType)2, 1118 },
	{ (Il2CppRGCTXDataType)3, 4497 },
	{ (Il2CppRGCTXDataType)2, 643 },
	{ (Il2CppRGCTXDataType)3, 63 },
	{ (Il2CppRGCTXDataType)3, 64 },
	{ (Il2CppRGCTXDataType)2, 1127 },
	{ (Il2CppRGCTXDataType)3, 4501 },
	{ (Il2CppRGCTXDataType)3, 14256 },
	{ (Il2CppRGCTXDataType)2, 648 },
	{ (Il2CppRGCTXDataType)3, 97 },
	{ (Il2CppRGCTXDataType)2, 2256 },
	{ (Il2CppRGCTXDataType)3, 9890 },
	{ (Il2CppRGCTXDataType)3, 14234 },
	{ (Il2CppRGCTXDataType)2, 644 },
	{ (Il2CppRGCTXDataType)3, 69 },
	{ (Il2CppRGCTXDataType)2, 746 },
	{ (Il2CppRGCTXDataType)3, 966 },
	{ (Il2CppRGCTXDataType)3, 967 },
	{ (Il2CppRGCTXDataType)2, 1842 },
	{ (Il2CppRGCTXDataType)3, 6255 },
	{ (Il2CppRGCTXDataType)2, 1675 },
	{ (Il2CppRGCTXDataType)2, 1246 },
	{ (Il2CppRGCTXDataType)2, 1345 },
	{ (Il2CppRGCTXDataType)2, 1439 },
	{ (Il2CppRGCTXDataType)2, 1346 },
	{ (Il2CppRGCTXDataType)2, 1440 },
	{ (Il2CppRGCTXDataType)3, 4499 },
	{ (Il2CppRGCTXDataType)2, 1347 },
	{ (Il2CppRGCTXDataType)2, 1441 },
	{ (Il2CppRGCTXDataType)3, 4500 },
	{ (Il2CppRGCTXDataType)2, 1674 },
	{ (Il2CppRGCTXDataType)2, 1344 },
	{ (Il2CppRGCTXDataType)2, 1438 },
	{ (Il2CppRGCTXDataType)2, 1334 },
	{ (Il2CppRGCTXDataType)2, 1335 },
	{ (Il2CppRGCTXDataType)2, 1435 },
	{ (Il2CppRGCTXDataType)3, 4496 },
	{ (Il2CppRGCTXDataType)2, 1245 },
	{ (Il2CppRGCTXDataType)2, 1342 },
	{ (Il2CppRGCTXDataType)2, 1343 },
	{ (Il2CppRGCTXDataType)2, 1437 },
	{ (Il2CppRGCTXDataType)3, 4498 },
	{ (Il2CppRGCTXDataType)2, 1244 },
	{ (Il2CppRGCTXDataType)3, 14221 },
	{ (Il2CppRGCTXDataType)3, 3882 },
	{ (Il2CppRGCTXDataType)2, 1006 },
	{ (Il2CppRGCTXDataType)2, 1337 },
	{ (Il2CppRGCTXDataType)2, 1436 },
	{ (Il2CppRGCTXDataType)2, 1514 },
	{ (Il2CppRGCTXDataType)3, 5867 },
	{ (Il2CppRGCTXDataType)3, 5869 },
	{ (Il2CppRGCTXDataType)2, 452 },
	{ (Il2CppRGCTXDataType)3, 5868 },
	{ (Il2CppRGCTXDataType)3, 5877 },
	{ (Il2CppRGCTXDataType)2, 1748 },
	{ (Il2CppRGCTXDataType)2, 2526 },
	{ (Il2CppRGCTXDataType)3, 12326 },
	{ (Il2CppRGCTXDataType)3, 5878 },
	{ (Il2CppRGCTXDataType)2, 1389 },
	{ (Il2CppRGCTXDataType)2, 1465 },
	{ (Il2CppRGCTXDataType)3, 4508 },
	{ (Il2CppRGCTXDataType)3, 14207 },
	{ (Il2CppRGCTXDataType)2, 2537 },
	{ (Il2CppRGCTXDataType)3, 12391 },
	{ (Il2CppRGCTXDataType)3, 5870 },
	{ (Il2CppRGCTXDataType)2, 1747 },
	{ (Il2CppRGCTXDataType)2, 2524 },
	{ (Il2CppRGCTXDataType)3, 12319 },
	{ (Il2CppRGCTXDataType)3, 4507 },
	{ (Il2CppRGCTXDataType)3, 5871 },
	{ (Il2CppRGCTXDataType)3, 14206 },
	{ (Il2CppRGCTXDataType)2, 2533 },
	{ (Il2CppRGCTXDataType)3, 12365 },
	{ (Il2CppRGCTXDataType)3, 5884 },
	{ (Il2CppRGCTXDataType)2, 1749 },
	{ (Il2CppRGCTXDataType)2, 2531 },
	{ (Il2CppRGCTXDataType)3, 12358 },
	{ (Il2CppRGCTXDataType)3, 6303 },
	{ (Il2CppRGCTXDataType)3, 3117 },
	{ (Il2CppRGCTXDataType)3, 4509 },
	{ (Il2CppRGCTXDataType)3, 3116 },
	{ (Il2CppRGCTXDataType)3, 5885 },
	{ (Il2CppRGCTXDataType)3, 14208 },
	{ (Il2CppRGCTXDataType)2, 2541 },
	{ (Il2CppRGCTXDataType)3, 12422 },
	{ (Il2CppRGCTXDataType)3, 5898 },
	{ (Il2CppRGCTXDataType)2, 1751 },
	{ (Il2CppRGCTXDataType)2, 2539 },
	{ (Il2CppRGCTXDataType)3, 12393 },
	{ (Il2CppRGCTXDataType)3, 5899 },
	{ (Il2CppRGCTXDataType)2, 1392 },
	{ (Il2CppRGCTXDataType)2, 1468 },
	{ (Il2CppRGCTXDataType)3, 4513 },
	{ (Il2CppRGCTXDataType)3, 4512 },
	{ (Il2CppRGCTXDataType)2, 2528 },
	{ (Il2CppRGCTXDataType)3, 12328 },
	{ (Il2CppRGCTXDataType)3, 14215 },
	{ (Il2CppRGCTXDataType)2, 2538 },
	{ (Il2CppRGCTXDataType)3, 12392 },
	{ (Il2CppRGCTXDataType)3, 5891 },
	{ (Il2CppRGCTXDataType)2, 1750 },
	{ (Il2CppRGCTXDataType)2, 2535 },
	{ (Il2CppRGCTXDataType)3, 12367 },
	{ (Il2CppRGCTXDataType)3, 4511 },
	{ (Il2CppRGCTXDataType)3, 4510 },
	{ (Il2CppRGCTXDataType)3, 5892 },
	{ (Il2CppRGCTXDataType)2, 2527 },
	{ (Il2CppRGCTXDataType)3, 12327 },
	{ (Il2CppRGCTXDataType)3, 14214 },
	{ (Il2CppRGCTXDataType)2, 2534 },
	{ (Il2CppRGCTXDataType)3, 12366 },
	{ (Il2CppRGCTXDataType)3, 5905 },
	{ (Il2CppRGCTXDataType)2, 1752 },
	{ (Il2CppRGCTXDataType)2, 2543 },
	{ (Il2CppRGCTXDataType)3, 12424 },
	{ (Il2CppRGCTXDataType)3, 6304 },
	{ (Il2CppRGCTXDataType)3, 3119 },
	{ (Il2CppRGCTXDataType)3, 4515 },
	{ (Il2CppRGCTXDataType)3, 4514 },
	{ (Il2CppRGCTXDataType)3, 3118 },
	{ (Il2CppRGCTXDataType)3, 5906 },
	{ (Il2CppRGCTXDataType)2, 2529 },
	{ (Il2CppRGCTXDataType)3, 12329 },
	{ (Il2CppRGCTXDataType)3, 14216 },
	{ (Il2CppRGCTXDataType)2, 2542 },
	{ (Il2CppRGCTXDataType)3, 12423 },
	{ (Il2CppRGCTXDataType)3, 4504 },
	{ (Il2CppRGCTXDataType)3, 4505 },
	{ (Il2CppRGCTXDataType)3, 4516 },
	{ (Il2CppRGCTXDataType)3, 100 },
	{ (Il2CppRGCTXDataType)3, 99 },
	{ (Il2CppRGCTXDataType)2, 1384 },
	{ (Il2CppRGCTXDataType)2, 1461 },
	{ (Il2CppRGCTXDataType)3, 4506 },
	{ (Il2CppRGCTXDataType)2, 1398 },
	{ (Il2CppRGCTXDataType)2, 1479 },
	{ (Il2CppRGCTXDataType)3, 102 },
	{ (Il2CppRGCTXDataType)2, 580 },
	{ (Il2CppRGCTXDataType)2, 649 },
	{ (Il2CppRGCTXDataType)3, 98 },
	{ (Il2CppRGCTXDataType)3, 101 },
	{ (Il2CppRGCTXDataType)3, 71 },
	{ (Il2CppRGCTXDataType)2, 2362 },
	{ (Il2CppRGCTXDataType)3, 11414 },
	{ (Il2CppRGCTXDataType)2, 1381 },
	{ (Il2CppRGCTXDataType)2, 1459 },
	{ (Il2CppRGCTXDataType)3, 11415 },
	{ (Il2CppRGCTXDataType)3, 73 },
	{ (Il2CppRGCTXDataType)2, 449 },
	{ (Il2CppRGCTXDataType)2, 645 },
	{ (Il2CppRGCTXDataType)3, 70 },
	{ (Il2CppRGCTXDataType)3, 72 },
	{ (Il2CppRGCTXDataType)3, 3915 },
	{ (Il2CppRGCTXDataType)2, 1020 },
	{ (Il2CppRGCTXDataType)2, 3061 },
	{ (Il2CppRGCTXDataType)3, 11411 },
	{ (Il2CppRGCTXDataType)3, 11412 },
	{ (Il2CppRGCTXDataType)2, 1528 },
	{ (Il2CppRGCTXDataType)3, 11413 },
	{ (Il2CppRGCTXDataType)2, 389 },
	{ (Il2CppRGCTXDataType)2, 646 },
	{ (Il2CppRGCTXDataType)3, 83 },
	{ (Il2CppRGCTXDataType)3, 9880 },
	{ (Il2CppRGCTXDataType)2, 747 },
	{ (Il2CppRGCTXDataType)3, 968 },
	{ (Il2CppRGCTXDataType)3, 9885 },
	{ (Il2CppRGCTXDataType)3, 3094 },
	{ (Il2CppRGCTXDataType)2, 483 },
	{ (Il2CppRGCTXDataType)3, 9881 },
	{ (Il2CppRGCTXDataType)2, 2253 },
	{ (Il2CppRGCTXDataType)3, 1002 },
	{ (Il2CppRGCTXDataType)2, 761 },
	{ (Il2CppRGCTXDataType)2, 981 },
	{ (Il2CppRGCTXDataType)3, 3100 },
	{ (Il2CppRGCTXDataType)3, 9882 },
	{ (Il2CppRGCTXDataType)3, 3089 },
	{ (Il2CppRGCTXDataType)3, 3090 },
	{ (Il2CppRGCTXDataType)3, 3088 },
	{ (Il2CppRGCTXDataType)3, 3091 },
	{ (Il2CppRGCTXDataType)2, 977 },
	{ (Il2CppRGCTXDataType)2, 3024 },
	{ (Il2CppRGCTXDataType)3, 4503 },
	{ (Il2CppRGCTXDataType)3, 3093 },
	{ (Il2CppRGCTXDataType)2, 1320 },
	{ (Il2CppRGCTXDataType)3, 3092 },
	{ (Il2CppRGCTXDataType)2, 1247 },
	{ (Il2CppRGCTXDataType)2, 2980 },
	{ (Il2CppRGCTXDataType)2, 1360 },
	{ (Il2CppRGCTXDataType)2, 1442 },
	{ (Il2CppRGCTXDataType)3, 3898 },
	{ (Il2CppRGCTXDataType)2, 1014 },
	{ (Il2CppRGCTXDataType)3, 4823 },
	{ (Il2CppRGCTXDataType)3, 4824 },
	{ (Il2CppRGCTXDataType)3, 4829 },
	{ (Il2CppRGCTXDataType)2, 1523 },
	{ (Il2CppRGCTXDataType)3, 4826 },
	{ (Il2CppRGCTXDataType)3, 14663 },
	{ (Il2CppRGCTXDataType)2, 983 },
	{ (Il2CppRGCTXDataType)3, 3109 },
	{ (Il2CppRGCTXDataType)1, 1317 },
	{ (Il2CppRGCTXDataType)2, 2992 },
	{ (Il2CppRGCTXDataType)3, 4825 },
	{ (Il2CppRGCTXDataType)1, 2992 },
	{ (Il2CppRGCTXDataType)1, 1523 },
	{ (Il2CppRGCTXDataType)2, 3059 },
	{ (Il2CppRGCTXDataType)2, 2992 },
	{ (Il2CppRGCTXDataType)3, 4830 },
	{ (Il2CppRGCTXDataType)3, 4828 },
	{ (Il2CppRGCTXDataType)3, 4827 },
	{ (Il2CppRGCTXDataType)2, 326 },
	{ (Il2CppRGCTXDataType)3, 3120 },
	{ (Il2CppRGCTXDataType)2, 462 },
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
