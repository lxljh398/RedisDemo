# RedisDemo

Demo中使用到了两种方案，推荐使用 *StackExchange.Redis*<br />
ServiceStack.Redis从4.0以后的版本开始收费，之前的版本不在维护免费升级，虽然StackExchange.Redis还有一定的差距，但是完全可供正常业务的使用，文档也存在一定的缺乏。

## ServiceStack.Redis

## StackExchange.Redis

推荐阅读  [超强、超详细Redis数据库入门教程](http://www.cnblogs.com/joeblackzqq/p/6229387.html)

## 在使用Redis之前应该了解Redis基本的一些内容

Redis是一款开源的、高性能的键-值存储（key-value store）。它常被称作是一款数据结构服务器（data structure server）。Redis的键值可以包括字符串（strings）、哈希（hashes）、列表（lists）、集合（sets）和 有序集合（sorted sets）等数据类型。 对于这些数据类型，你可以执行原子操作。例如：对字符串进行附加操作（append）；递增哈希中的值；向列表中增加元素；计算集合的交集、并集与差集等。

    为了获得优异的性能，Redis采用了内存中（in-memory）数据集（dataset）的方式。根据使用场景的不同，你可以每隔一段时间将数据集转存到磁盘上来持久化数据，或者在日志尾部追加每一条操作命令。

    Redis同样支持主从复制（master-slave replication），并且具有非常快速的非阻塞首次同步(non-blocking first synchronization)、网络断开自动重连等功能。同时Redis还具有其它一些特性，其中包括简单的check-and-set机制、pub/sub和配置设置等，以便使得Redis能够表现得更像缓存（cache）。

    Redis还提供了丰富的客户端，以便支持现阶段流行的大多数编程语言。详细的支持列表可以参看Redis官方文档：http://redis.io/clients。Redis自身使用ANSI C来编写，并且能够在不产生外部依赖（external dependencies）的情况下运行在大多数POSIX系统上，例如：Linux、*BSD、OS X和Solaris等。 

Redis 由四个可执行文件：redis-benchmark、redis-cli、redis-server、redis-stat 这四个文件，加上一个redis.conf就构成了整个redis的最终可用包。它们的作用如下：

    redis-server：Redis服务器的daemon启动程序
    redis-cli：Redis命令行操作工具。当然，你也可以用telnet根据其纯文本协议来操作
    redis-benchmark：Redis性能测试工具，测试Redis在你的系统及你的配置下的读写性能
    redis-stat：Redis状态检测工具，可以检测Redis当前状态参数及延迟状况

现在就可以启动redis了，redis只有一个启动参数，就是他的配置文件路径。


使用Redis开发应用程序是一个很愉快的过程，但是就像其他技术一样，基于Redis的应用程序设计你同样需要牢记几点。在之前，你可能已经对关系型数据库开发的那一整个套路了然如胸，而基于Redis的应用程序开发也有许多相似的地方，但是你必须牢记以下两点——Redis是个内存数据库，同时它是单线程的。因此，在使用Redis时，你需要注意以下几点：

+ 1.掌控储存在Redis中的所有键

数据库的主要功能是储存数据，但是对于开发者来说，因为应用程序需求或者数据使用方法的改变，忽略存储在数据库中的某些数据是非常正常的，在Redis中同样如此。你可能忽视期满某些键，也可能因为应用程序的某个模块弃用而忘掉这些数据。

无论哪种情况，Redis都存储了一些不再使用的数据，平白无故的占用了一些空间。Redis的弱结构数据模式让集中储存的内容很难被弄清，除非你为键使用一套非常成熟的命名法则。使用合适的命名方法会简化你的数据库管理，当你通过你的应用程序或者服务做键的命名空间时（通常情况下是使用冒号来划分键名），你就可以在数据迁移、转换或者删除时轻松的识别。
Redis是一款开源的、高性能的键-值存储（key-value store）。它常被称作是一款数据结构服务器（data structure server）。Redis的键值可以包括字符串（strings）、哈希（hashes）、列表（lists）、集合（sets）和 有序集合（sorted sets）等数据类型。 对于这些数据类型，你可以执行原子操作。例如：对字符串进行附加操作（append）；递增哈希中的值；向列表中增加元素；计算集合的交集、并集与差集等。

    为了获得优异的性能，Redis采用了内存中（in-memory）数据集（dataset）的方式。根据使用场景的不同，你可以每隔一段时间将数据集转存到磁盘上来持久化数据，或者在日志尾部追加每一条操作命令。

    Redis同样支持主从复制（master-slave replication），并且具有非常快速的非阻塞首次同步(non-blocking first synchronization)、网络断开自动重连等功能。同时Redis还具有其它一些特性，其中包括简单的check-and-set机制、pub/sub和配置设置等，以便使得Redis能够表现得更像缓存（cache）。

    Redis还提供了丰富的客户端，以便支持现阶段流行的大多数编程语言。详细的支持列表可以参看Redis官方文档：http://redis.io/clients。Redis自身使用ANSI C来编写，并且能够在不产生外部依赖（external dependencies）的情况下运行在大多数POSIX系统上，例如：Linux、*BSD、OS X和Solaris等。 

Redis另一个常见用例是作为热数据项作的第二数据存储，大部分的数据被保存在其他的数据库中，比如PostgreSQL或MongoDB。在这些用例中，当数据从主存储移除时，开发者经常会忘记删除Redis中对应的数据。这种存在跨数据存储的情况下，通常需要做级联删除，这种情况下，可以通过在Redis配置保存特定数据项的所有识别符来实现，从而保证数据在主数据库被删除后，系统会调用一个清理程序来删除所有相关副本和信息。

+ 2.控制所有键名的长度

在上文我们说过要使用合适的命名规则，并且添加前缀来识别数据走向，因此这一条看起来似乎与之违背。但是，请别忘记，Redis是个内存数据库，键越短你需要的空间就越少。理所当然，当数据库中拥有数百万或者数十亿键时，键名的长度将影响重大。

举个例子：在一个32位的Redis服务器上，如果储存一百万个键，每个值的长度是32-character，那么在使用6-character长度键名时，将会消耗大约96MB的空间，但是如果使用12-character长度的键名时，空间消耗则会提升至111MB左右。随着键的增多，15%的额外开销将产生重大的影响。

+ 3.使用合适的数据结构

不管是内存使用或者是性能，有的时候数据结构将产生很大的影响，下面是一些可以参考的最佳实践：

取代将数据存储为数千（或者数百万）独立的字符串，可以考虑使用哈希数据结构将相关数据进行分组。哈希表是非常有效率的，并且可以减少你的内存使用；同时，哈希还更有益于细节抽象和代码可读。

合适时候，使用list代替set。如果你不需要使用set特性，List在使用更少内存的情况下可以提供比set更快的速度。

Sorted sets是最昂贵的数据结构，不管是内存消耗还是基本操作的复杂性。如果你只是需要一个查询记录的途径，并不在意排序这样的属性，那么轻建议使用哈希表。

Redis中一个经常被忽视的功能就是bitmaps或者bitsets（V2.2之后）。Bitsets允许你在Redis值上执行多个bit-level操作，比如一些轻量级的分析。

+ 4.使用SCAN时别使用键

从Redis v2.8开始，SCAN命令已经可用，它允许使用游标从keyspace中检索键。对比KEYS命令，虽然SCAN无法一次性返回所有匹配结果，但是却规避了阻塞系统这个高风险，从而也让一些操作可以放在主节点上执行。

需要注意的是，SCAN 命令是一个基于游标的迭代器。SCAN 命令每次被调用之后， 都会向用户返回一个新的游标，用户在下次迭代时需要使用这个新游标作为 SCAN 命令的游标参数， 以此来延续之前的迭代过程。同时，使用SCAN，用户还可以使用keyname模式和count选项对命令进行调整。

SCAN相关命令还包括SSCAN 命令、HSCAN 命令和 ZSCAN 命令，分别用于集合、哈希键及有续集等。

+ 5.使用服务器端Lua脚本

在Redis使用过程中，Lua脚本的支持无疑给开发者提供一个非常友好的开发环境，从而大幅度解放用户的创造力。如果使用得当，Lua脚本可以给性能和资源消耗带来非常大的改善。取代将数据传送给CPU，脚本允许你在最接近数据的地方执行逻辑，从而减少网络延时和数据的冗余传输。

在Redis中，Lua一个非常经典的用例就是数据过滤或者将数据聚合到应用程序。通过将处理工作流封装到一个脚本中，你只需要调用它就可以在更短的时间内使用很少的资源来获取一个更小的答案。

专家提示：Lua确实非常棒，但是同样也存在一些问题，比如很难进行错误报告和处理。一个明智的方法就是使用Redis的Pub/Sub功能，并且让脚本通过专用信道来推送日志消息。然后建立一个订阅者进程，并进行相应的处理。




### Redis与Memcached的区别：

如果简单地比较Redis与Memcached的区别，大多数都会得到以下观点：
+ 1 Redis不仅仅支持简单的k/v类型的数据，同时还提供list，set，hash等数据结构的存储。<br />
+ 2 Redis支持数据的备份，即master-slave模式的数据备份。<br />
+ 3 Redis支持数据的持久化，可以将内存中的数据保持在磁盘中，重启的时候可以再次加载进行使用。<br />

在Redis中，并不是所有的数据都一直存储在内存中的。这是和Memcached相比一个最大的区别（我个人是这么认为的）。

Redis只会缓存所有的key的信息，如果Redis发现内存的使用量超过了某一个阀值，将触发swap的操作，Redis根据“swappability = age*log(size_in_memory)”计算出哪些key对应的value需要swap到磁盘。然后再将这些key对应的value持久化到磁盘中，同时在内存中清除。这种特性使得Redis可以保持超过其机器本身内存大小的数据。当然，机器本身的内存必须要能够保持所有的key，毕竟这些数据是不会进行swap操作的。

同时由于Redis将内存中的数据swap到磁盘中的时候，提供服务的主线程和进行swap操作的子线程会共享这部分内存，所以如果更新需要swap的数据，Redis将阻塞这个操作，直到子线程完成swap操作后才可以进行修改。

可以参考使用Redis特有内存模型前后的情况对比：

VM off: 300k keys, 4096 bytes values: 1.3G used<br />
VM on: 300k keys, 4096 bytes values: 73M used<br />
VM off: 1 million keys, 256 bytes values: 430.12M used<br />
VM on: 1 million keys, 256 bytes values: 160.09M used<br />
VM on: 1 million keys, values as large as you want, still: 160.09M used <br />

当从Redis中读取数据的时候，如果读取的key对应的value不在内存中，那么Redis就需要从swap文件中加载相应数据，然后再返回给请求方。这里就存在一个I/O线程池的问题。在默认的情况下，Redis会出现阻塞，即完成所有的swap文件加载后才会相应。这种策略在客户端的数量较小，进行批量操作的时候比较合适。但是如果将Redis应用在一个大型的网站应用程序中，这显然是无法满足大并发的情况的。所以Redis运行我们设置I/O线程池的大小，对需要从swap文件中加载相应数据的读取请求进行并发操作，减少阻塞的时间。



### redis、memcache、mongoDB 对比
从以下几个维度，对redis、memcache、mongoDB 做了对比，欢迎拍砖

+ 1、性能<br />
都比较高，性能对我们来说应该都不是瓶颈<br />
总体来讲，TPS方面redis和memcache差不多，要大于mongodb


+ 2、操作的便利性<br />
memcache数据结构单一<br />
redis丰富一些，数据操作方面，redis更好一些，较少的网络IO次数<br />
mongodb支持丰富的数据表达，索引，最类似关系型数据库，支持的查询语言非常丰富


+ 3、内存空间的大小和数据量的大小<br />
redis在2.0版本后增加了自己的VM特性，突破物理内存的限制；可以对key value设置过期时间（类似memcache）<br />
memcache可以修改最大可用内存,采用LRU算法<br />
mongoDB适合大数据量的存储，依赖操作系统VM做内存管理，吃内存也比较厉害，服务不要和别的服务在一起

+ 4、可用性（单点问题）<br />
对于单点问题，
redis，依赖客户端来实现分布式读写；主从复制时，每次从节点重新连接主节点都要依赖整个快照,无增量复制，因性能和效率问题，
所以单点问题比较复杂；不支持自动sharding,需要依赖程序设定一致hash 机制。<br />
一种替代方案是，不用redis本身的复制机制，采用自己做主动复制（多份存储），或者改成增量复制的方式（需要自己实现），一致性问题和性能的权衡<br />
Memcache本身没有数据冗余机制，也没必要；对于故障预防，采用依赖成熟的hash或者环状的算法，解决单点故障引起的抖动问题。<br />
mongoDB支持master-slave,replicaset（内部采用paxos选举算法，自动故障恢复）,auto sharding机制，对客户端屏蔽了故障转移和切分机制。


+ 5、可靠性（持久化）<br />
对于数据持久化和数据恢复，
redis支持（快照、AOF）：依赖快照进行持久化，aof增强了可靠性的同时，对性能有所影响<br />
memcache不支持，通常用在做缓存,提升性能；<br />
MongoDB从1.8版本开始采用binlog方式支持持久化的可靠性


+ 6、数据一致性（事务支持）<br />
Memcache 在并发场景下，用cas保证一致性<br />
redis事务支持比较弱，只能保证事务中的每个操作连续执行<br />
mongoDB不支持事务


+ 7、数据分析<br />
mongoDB内置了数据分析的功能(mapreduce),其他不支持


+ 8、应用场景<br />
redis：数据量较小的更性能操作和运算上<br />
memcache：用于在动态系统中减少数据库负载，提升性能;做缓存，提高性能（适合读多写少，对于数据量比较大，可以采用sharding）<br />
MongoDB:主要解决海量数据的访问效率问题 