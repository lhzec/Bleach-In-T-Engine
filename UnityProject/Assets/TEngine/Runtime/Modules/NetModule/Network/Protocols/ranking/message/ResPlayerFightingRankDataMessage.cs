using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 总战力排行榜数据 message
 */
public class ResPlayerFightingRankDataMessage : Message 
{
	//总战力排行榜列表
	List<PlayerFightingRankBean> _playerFightingRankBean = new List<PlayerFightingRankBean>();
	//自己排名
	int _rank;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//总战力排行榜列表
		SerializeUtils.WriteShort(stream, (short)_playerFightingRankBean.Count);

		foreach (var element in _playerFightingRankBean)  
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
		//总战力排行榜列表
		int _playerFightingRankBean_length = SerializeUtils.ReadShort(stream);
		for (int i = 0; i < _playerFightingRankBean_length; ++i) 
		{
			_playerFightingRankBean.Add(SerializeUtils.ReadBean<PlayerFightingRankBean>(stream));
		}
		//自己排名
		_rank = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * get 总战力排行榜列表
	 * @return 
	 */
	public List<PlayerFightingRankBean> GetPlayerFightingRankBean()
	{
		return _playerFightingRankBean;
	}
	
	/**
	 * set 总战力排行榜列表
	 */
	public void SetPlayerFightingRankBean(List<PlayerFightingRankBean> playerFightingRankBean)
	{
		_playerFightingRankBean = playerFightingRankBean;
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
		return 209105;
	}
}