using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家竞技场信息
 */
public class ArenaInfo : IMessageSerialize 
{
	//竞技场排名
	int _rank;	
	//竞技场最高排名
	int _bestRank;	
	//竞技场点数
	int _arenaPoint;	
	//剩余挑战次数
	int _leftCount;	
	//cd剩余秒数
	int _cdTime;	
	//竞技场购买次数
	int _buyTime;	
	//竞技场连续胜利次数
	int _totalWinCount;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//竞技场排名
		SerializeUtils.WriteInt(stream, _rank);
		//竞技场最高排名
		SerializeUtils.WriteInt(stream, _bestRank);
		//竞技场点数
		SerializeUtils.WriteInt(stream, _arenaPoint);
		//剩余挑战次数
		SerializeUtils.WriteInt(stream, _leftCount);
		//cd剩余秒数
		SerializeUtils.WriteInt(stream, _cdTime);
		//竞技场购买次数
		SerializeUtils.WriteInt(stream, _buyTime);
		//竞技场连续胜利次数
		SerializeUtils.WriteInt(stream, _totalWinCount);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//竞技场排名
		_rank = SerializeUtils.ReadInt(stream);
		//竞技场最高排名
		_bestRank = SerializeUtils.ReadInt(stream);
		//竞技场点数
		_arenaPoint = SerializeUtils.ReadInt(stream);
		//剩余挑战次数
		_leftCount = SerializeUtils.ReadInt(stream);
		//cd剩余秒数
		_cdTime = SerializeUtils.ReadInt(stream);
		//竞技场购买次数
		_buyTime = SerializeUtils.ReadInt(stream);
		//竞技场连续胜利次数
		_totalWinCount = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 竞技场排名
	 */
	public int Rank
	{
		set { _rank = value; }
	    get { return _rank; }
	}
	
	/**
	 * 竞技场最高排名
	 */
	public int BestRank
	{
		set { _bestRank = value; }
	    get { return _bestRank; }
	}
	
	/**
	 * 竞技场点数
	 */
	public int ArenaPoint
	{
		set { _arenaPoint = value; }
	    get { return _arenaPoint; }
	}
	
	/**
	 * 剩余挑战次数
	 */
	public int LeftCount
	{
		set { _leftCount = value; }
	    get { return _leftCount; }
	}
	
	/**
	 * cd剩余秒数
	 */
	public int CdTime
	{
		set { _cdTime = value; }
	    get { return _cdTime; }
	}
	
	/**
	 * 竞技场购买次数
	 */
	public int BuyTime
	{
		set { _buyTime = value; }
	    get { return _buyTime; }
	}
	
	/**
	 * 竞技场连续胜利次数
	 */
	public int TotalWinCount
	{
		set { _totalWinCount = value; }
	    get { return _totalWinCount; }
	}
	
}