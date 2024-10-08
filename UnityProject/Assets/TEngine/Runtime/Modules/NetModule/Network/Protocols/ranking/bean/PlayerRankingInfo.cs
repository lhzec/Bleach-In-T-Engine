using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 自己的排行榜数据
 */
public class PlayerRankingInfo : IMessageSerialize 
{
	//排名
	int _rank;	
	//可获取的奖励点数
	int _point;	
	
	/**
	 * 序列化
	 */
	public void Serialize(Stream stream)
	{
		//排名
		SerializeUtils.WriteInt(stream, _rank);
		//可获取的奖励点数
		SerializeUtils.WriteInt(stream, _point);
	}
	
	/**
	 * 反序列化
	 */
	public void Deserialize(Stream stream)
	{
		//排名
		_rank = SerializeUtils.ReadInt(stream);
		//可获取的奖励点数
		_point = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 排名
	 */
	public int Rank
	{
		set { _rank = value; }
	    get { return _rank; }
	}
	
	/**
	 * 可获取的奖励点数
	 */
	public int Point
	{
		set { _point = value; }
	    get { return _point; }
	}
	
}