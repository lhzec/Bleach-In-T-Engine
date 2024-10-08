using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 等级排行榜数据 message
 */
public class ResPlayerLevelRankDataMessage : Message 
{
	//等级排行榜列表
	List<PlayerLevelRankBean> _playerLevelRankBean = new List<PlayerLevelRankBean>();
	//自己排名
	int _rank;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//等级排行榜列表
		SerializeUtils.WriteShort(stream, (short)_playerLevelRankBean.Count);

		foreach (var element in _playerLevelRankBean)  
		{
			SerializeUtils.WriteBean(stream, element);
		}
		//自己排名
		SerializeUtils.WriteInt(stream, _rank);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//等级排行榜列表
		int _playerLevelRankBean_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _playerLevelRankBean_length; ++i) 
		{
			_playerLevelRankBean.Add(SerializeUtils.ReadBean<PlayerLevelRankBean>(stream));
		}
		//自己排名
		_rank = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 等级排行榜列表
	 * @return 
	 */
	public List<PlayerLevelRankBean> GetPlayerLevelRankBean()
	{
		return _playerLevelRankBean;
	}
	
	/**
	 * set 等级排行榜列表
	 */
	public void SetPlayerLevelRankBean(List<PlayerLevelRankBean> playerLevelRankBean)
	{
		_playerLevelRankBean = playerLevelRankBean;
	}
	
	/**
	 * 自己排名
	 */
	public int Rank
	{
		set { _rank = value; }
	    get { return _rank; }
	}
	
	
	public override int GetId() 
	{
		return 209106;
	}
}